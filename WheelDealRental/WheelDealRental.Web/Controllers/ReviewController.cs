using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WheelDealRental.Repository;
using WheelDealRental.Repository.Interface;
using WheelDealRental.Service.Interface;

namespace WheelDealRental.Web.Controllers
{
    public class ReviewController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IReviewService reviewService;
        private readonly IVehicleService vehicleService;
       
        public ReviewController(ApplicationDbContext context,
            IReviewService reviewService, IVehicleService vehicleService)
        {
            this._context = context;
            this.reviewService = reviewService;
            this.vehicleService = vehicleService;
            
        }
        [HttpGet]
        public IActionResult Show(Guid vehicleId)
        {
            //get reviews for car
            var model = reviewService.GetAllReviewsForVehicle(vehicleId);
            ViewBag.Vehicle= vehicleService.GetVehicle(vehicleId); 
            return View(model);
        }
        [HttpPost]
        public IActionResult Add(Guid vehicleId, string userId, int starHidden, string reviewText)
        {
            reviewService.AddReview(userId, vehicleId, starHidden, reviewText);
            return RedirectToAction("Show",new { vehicleId= vehicleId});
        }
        [HttpGet]
        public IActionResult Delete(Guid reviewId, Guid vehicleId)
        {
            reviewService.DeleteReview(reviewId);
            var model = reviewService.GetAllReviewsForVehicle(vehicleId);
            ViewBag.Vehicle = vehicleService.GetVehicle(vehicleId);
            return RedirectToAction("Show", new { vehicleId = vehicleId });
        }


    }
}
