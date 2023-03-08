using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WheelDealRental.Domain.DomainModels;
using WheelDealRental.Repository;
using WheelDealRental.Service.Interface;

namespace WheelDealRental.Web.Controllers
{
    public class LocationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public readonly ILocationService locationService;

        public LocationsController(ApplicationDbContext context, ILocationService locationService)
        {
            _context = context;
            this.locationService = locationService;
        }

        // GET: Locations
        public IActionResult Index()
        {
            List<Location> locations = locationService.GetAllLocations();
            return View(locations);
        }

        // GET: Locations/Details/5
        public IActionResult Details(Guid id)
        {
            if (id == null || id==Guid.Empty)
            {
                return RedirectToAction("Index","Home");
            }
            else
            {
                
                List<Vehicle> vehicles = locationService.GetAllVehiclesForLocation(id);
                return View(vehicles);
            }
           
        }

        // GET: Locations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Locations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public IActionResult Create(string name, string street, string streetNumber, string open, string close)
        {
            locationService.AddNewLocation(name, street, streetNumber, DateTime.Parse(open), DateTime.Parse(close));
            return RedirectToAction("Index");
        }

        // GET: Locations/Edit/5
        public IActionResult Edit(Guid id)
        {
            Location location = locationService.GetLocation(id);
            return View(location);
        }

        // POST: Locations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public IActionResult Edit(Guid id, string name, string street, string streetNumber, string open, string close)
        {
            locationService.UpdateLocation(id, name, street, streetNumber, DateTime.Parse(open), DateTime.Parse(close));
            return RedirectToAction("Index");
        }

        // GET: Locations/Delete/5
        public IActionResult Delete(Guid id)
        {
            locationService.CloseLocation(id);
            return RedirectToAction("Index");
        }
    }
}
