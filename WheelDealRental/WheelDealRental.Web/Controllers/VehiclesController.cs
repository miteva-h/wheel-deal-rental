using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WheelDealRental.Domain.DomainModels;
using WheelDealRental.Repository;
using WheelDealRental.Service.Interface;

namespace WheelDealRental.Web.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IVehicleService vehicleService;
        private readonly ILocationService locationService;

        public VehiclesController(ApplicationDbContext context, 
            IVehicleService vehicleService, 
            ILocationService locationService)
        {
            _context = context;
            this.vehicleService = vehicleService;
            this.locationService = locationService;
        }

        // GET: Vehicles
        public IActionResult Index()
        {
            var allVehiclesWithLocations = vehicleService.GetAllVehiclesWithLocations();
            return View(allVehiclesWithLocations);
        }

        // GET: Vehicles/Details/5
        public IActionResult Details(Guid id)
        {
            var vehicle = vehicleService.GetVehicleWithLocation(id);
            ViewBag.dateAvailable = 2;

            return View(vehicle);
        }
        // GET: Vehicles/CheckDate/5
        public IActionResult CheckDate(Guid id, string dateFrom, string dateTo)
        {
            if (dateFrom != null && dateTo != null)
            {
                var vehicle = vehicleService.GetVehicleWithLocation(id);
                ViewBag.dateAvailable = 2;
                if (vehicleService.CheckIfAvailableDate(id, DateTime.Parse(dateFrom), DateTime.Parse(dateTo)))
                {
                    ViewBag.dateAvailable = 1;
                    ViewBag.dateFrom = dateFrom;
                    ViewBag.dateTo = dateTo;
                }
                else
                {
                    ViewBag.dateAvailable = 0;
                }


                return View("Details", vehicle);
            }
            else
            {
                var vehicle = vehicleService.GetVehicleWithLocation(id);
                ViewBag.dateAvailable = 2;

                return View("Details", vehicle);
            }

        }

        // GET: Vehicles/Create
        public IActionResult Create()
        {
            ViewBag.locations = locationService.GetAllLocations(); 
            return View();
        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
       
        public IActionResult Create(string registration,string brand,string model, string color,string fuel,int price,string photo,Guid location)
        {
            vehicleService.AddNewVehicle(location, registration, brand, model, color, fuel, price, photo);
            return RedirectToAction("Index");
        }

        // GET: Vehicles/Edit/5
        public IActionResult Edit(Guid id)
        {
            var vehicle = vehicleService.GetVehicleWithLocation(id);
            ViewBag.locations = locationService.GetAllLocations();
            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public IActionResult Edit(Guid id, int price, string photo, Guid location)
        {
            vehicleService.UpdateVehicle(id, location, price, photo);
            return RedirectToAction("Index");

        }

        // GET: Vehicles/Delete/5
        public IActionResult Delete(Guid id)
        {
            vehicleService.DeleteVehicle(id);
            return RedirectToAction("Index");
        }

        public IActionResult AddToShoppingCart(Guid id, string dateFrom, string dateTo)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            vehicleService.AddToShoppingCart(userId, id, DateTime.Parse(dateFrom), DateTime.Parse(dateTo));
            return RedirectToAction("Index","ShoppingCarts");
        }

    }
}
