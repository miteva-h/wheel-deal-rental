using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using GemBox.Document;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Stripe;
using WheelDealRental.Domain.DomainModels;
using WheelDealRental.Domain.Identity;
using WheelDealRental.Repository;
using WheelDealRental.Repository.Interface;
using WheelDealRental.Service.Interface;

namespace WheelDealRental.Web.Controllers
{
    public class ShoppingCartsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IShoppingCartService shoppingCartService;
        private readonly IVehicleService vehicleService;
        private readonly IOrderService orderService;
        private readonly IUserRepository userRepository;
        private readonly IEmailService emailService;

        public ShoppingCartsController(ApplicationDbContext context,
            IShoppingCartService shoppingCartService,
            IVehicleService vehicleService,
            IOrderService orderService,
            IUserRepository userRepository,
            IEmailService emailService)
        {
            _context = context;
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            this.shoppingCartService = shoppingCartService;
            this.vehicleService = vehicleService;
            this.orderService = orderService;
            this.userRepository = userRepository;
            this.emailService = emailService;
        }

        // GET: ShoppingCarts
        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var shoppingCartInfo = shoppingCartService.GetShoppingCartInfo(userId);
            return View(shoppingCartInfo);
        }


        public IActionResult Delete(Guid id)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            this.shoppingCartService.DeleteVehicleFromShoppingCart(userId, id);
            return RedirectToAction("Index", "ShoppingCarts");
        }

        public Boolean Order()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var result = this.shoppingCartService.Order(userId);

            return result;
        }

        public IActionResult MakeOrder()
        {
           /* string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            ERentalUser user = userRepository.Get(userId);
            string mail = user.Email;
            EmailMessage email = new EmailMessage();
            email.MailTo = mail;
            email.Status = true;
            email.Subject = "Successful order for " + user.UserName;

            List<EmailMessage> mailToBeSent = new List<EmailMessage>();
            mailToBeSent.Add(email);*/

           

            return View();
        }

        [HttpPost]
        public IActionResult PayOrder(string stripeEmail, string stripeToken)
        {
            var customerService = new CustomerService();
            var chargeService = new ChargeService();
            string userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var order = this.shoppingCartService.GetShoppingCartInfo(userId);

            var customer = customerService.Create(new CustomerCreateOptions
            {
                Email = stripeEmail,
                Source = stripeToken
            });

            var charge = chargeService.Create(new ChargeCreateOptions
            {
                Amount = (Convert.ToInt32(order.TotalPrice) * 100),
                Description = "WheelDealRental Application Payment",
                Currency = "usd",
                Customer = customer.Id
            });

            if (charge.Status == "succeeded")
            {
                var result = this.Order();
            }

            return RedirectToAction("MakeOrder", "ShoppingCarts");
        }

        [HttpGet]
        public IActionResult ExportOrder()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = userRepository.Get(userId);
            Order order = orderService.GetAllOrdersForUser(userId).LastOrDefault();
            order = orderService.GetOrderDetails(order.Id);

            var templatePath = Path.Combine("./", "ExportOrder.docx");
            var document = DocumentModel.Load(templatePath);


            document.Content.Replace("{{OrderNumber}}", order.Id.ToString());
            document.Content.Replace("{{CustomerEmail}}", order.AppUser.Email);
            document.Content.Replace("{{CustomerInfo}}", (order.AppUser.FirstName + " " + order.AppUser.LastName));

            StringBuilder sb = new StringBuilder();

            foreach (var item in order.VehiclesInOrder)
            {

                sb.AppendLine(item.Vehicle.Brand + item.Vehicle.Model + " for daily price of: $" + item.Vehicle.Price + " from " + item.From.ToShortDateString() + " to " + item.To.ToShortDateString());
            }

            document.Content.Replace("{{AllVehicles}}", sb.ToString());
            document.Content.Replace("{{TotalPrice}}", "$" + order.TotalPrice.ToString());

            var stream = new MemoryStream();

            document.Save(stream, new PdfSaveOptions());


            return File(stream.ToArray(), new PdfSaveOptions().ContentType, "ExportOrderDetails.pdf");
        }


    }
}
