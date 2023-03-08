using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WheelDealRental.Domain.DomainModels;
using WheelDealRental.Domain.DTO;
using WheelDealRental.Domain.Relations;
using WheelDealRental.Repository.Interface;
using WheelDealRental.Service.Interface;

namespace WheelDealRental.Service.Implementation
{
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly IUserRepository UserRepository;
        private readonly IRepository<ShoppingCart> ShoppingCartRepository;
        private readonly IVehicleService VehicleService;
        private readonly IRepository<Order> OrderRepository;
        private readonly IRepository<VehicleInOrder> VehicleInOrderRepository;
        private readonly IVehicleInShoppingCartRepository VehicleInShoppingCartRepositoryAdvanced;
        private readonly IRepository<EmailMessage> MailRepository;
        private readonly IEmailService emailService;

        public ShoppingCartService(IUserRepository UserRepository, 
            IRepository<ShoppingCart> ShoppingCartRepository,
            IVehicleService VehicleService,
            IVehicleInShoppingCartRepository VehicleInShoppingCartRepositoryAdvanced,
            IRepository<Order> OrderRepository,
            IRepository<VehicleInOrder> VehicleInOrderRepository,
            IRepository<EmailMessage> MailRepository,
            IEmailService emailService)
        {
            this.UserRepository = UserRepository;
            this.ShoppingCartRepository = ShoppingCartRepository;
            this.VehicleService = VehicleService;
            this.VehicleInShoppingCartRepositoryAdvanced = VehicleInShoppingCartRepositoryAdvanced;
            this.OrderRepository = OrderRepository;
            this.VehicleInOrderRepository = VehicleInOrderRepository;
            this.MailRepository = MailRepository;
            this.emailService = emailService;
        }
        public void DeleteVehicleFromShoppingCart(string AppUserId, Guid VehicleId)
        {
            var loggedInUser = this.UserRepository.Get(AppUserId);
            var userShoppingCart = loggedInUser.ShoppingCart;
            var itemToDelete = userShoppingCart.VehiclesInShoppingCart.Where(x => x.VehicleId.Equals(VehicleId)).FirstOrDefault();
            userShoppingCart.VehiclesInShoppingCart.Remove(itemToDelete);
            this.ShoppingCartRepository.Update(userShoppingCart);
            VehicleService.ReturnVehicle(VehicleId, itemToDelete.From, itemToDelete.To);
        }

        public ShoppingCartDto GetShoppingCartInfo(string AppUserId)
        {
            var loggedInUser = this.UserRepository.Get(AppUserId);
            var userShoppingCart = loggedInUser.ShoppingCart;
            var totalPrice = 0;

            var vehiclesInShoppingCart = VehicleInShoppingCartRepositoryAdvanced.GetAllVehiclesWithLocations().Where(x => x.ShoppingCartId == userShoppingCart.Id).ToList();

            foreach (var item in vehiclesInShoppingCart)
            {
                for (var dt = item.From; dt <= item.To; dt = dt.AddDays(1))
                {
                    totalPrice += item.Vehicle.Price;

                }
            }
            var result = new ShoppingCartDto 
            { 
                TotalPrice = totalPrice, 
                VehiclesInShoppingCart = vehiclesInShoppingCart 
            };
            return result;
        }

        public bool Order(string AppUserId)
        {
            if (!string.IsNullOrEmpty(AppUserId))
            {
                var loggedInUser = this.UserRepository.Get(AppUserId);
                var userShoppingCart = loggedInUser.ShoppingCart;

                //
                EmailMessage mail = new EmailMessage();
                mail.MailTo = loggedInUser.Email;
                mail.Subject = "Sucessfuly created order!";
                mail.Status = false;
                //

                var totalPriceTemp = 0;
                foreach (var x in userShoppingCart.VehiclesInShoppingCart)
                {
                    for (var dt = x.From; dt <= x.To; dt = dt.AddDays(1))
                    {
                        totalPriceTemp += x.Vehicle.Price;

                    }
                }

                Order order = new Order
                {
                    Id = Guid.NewGuid(),
                    AppUser = loggedInUser,
                    UserId = AppUserId,
                    TotalPrice = totalPriceTemp
                };

                this.OrderRepository.Insert(order);

                var result = userShoppingCart.VehiclesInShoppingCart.Select(z => new VehicleInOrder
                {
                    Id = Guid.NewGuid(),
                    VehicleId = z.VehicleId,
                    Vehicle = z.Vehicle,
                    OrderId = order.Id,
                    Order = order,
                    From = z.From,
                    To = z.To
                }).ToList();

                //
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Your order is completed. The order contains: ");

                for (int i = 1; i <= result.Count(); i++)
                {
                    var currentItem = result[i - 1];
                    sb.AppendLine(i.ToString() + ". " + currentItem.Vehicle.Brand + currentItem.Vehicle.Model + " for daily price of: $" + currentItem.Vehicle.Price + " from " + currentItem.From.ToShortDateString() + " to " + currentItem.To.ToShortDateString());
                }

                sb.AppendLine("Total price for your order: " + order.TotalPrice +" $");

                mail.Content = sb.ToString();
                //

                foreach (var item in result)
                {
                    this.VehicleInOrderRepository.Insert(item);
                }

                loggedInUser.ShoppingCart.VehiclesInShoppingCart.Clear();

                this.UserRepository.Update(loggedInUser);
                this.ShoppingCartRepository.Update(loggedInUser.ShoppingCart);

                //
                this.MailRepository.Insert(mail);
                List<EmailMessage> allMessages = this.MailRepository.GetAll().ToList();
                emailService.SendEmailAsync(allMessages);
                //

                return true;
            }

            return false;
        }
    }
}
