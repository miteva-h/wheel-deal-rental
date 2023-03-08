using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WheelDealRental.Domain;
using WheelDealRental.Domain.DomainModels;
using WheelDealRental.Repository.Interface;
using WheelDealRental.Service.Interface;

namespace WheelDealRental.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserRepository userRepository;
        private readonly ILocationService locationService;

        public HomeController(ILogger<HomeController> logger, IUserRepository userRepository, ILocationService locationService)
        {
            _logger = logger;
            this.userRepository = userRepository;
            this.locationService = locationService;
        }

        public IActionResult Index()
        {
            List<Location> locations = locationService.GetAllLocations();
            return View(locations);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
