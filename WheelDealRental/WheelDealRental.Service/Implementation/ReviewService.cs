using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WheelDealRental.Domain.DomainModels;
using WheelDealRental.Repository.Interface;
using WheelDealRental.Service.Interface;

namespace WheelDealRental.Service.Implementation
{
    public class ReviewService : IReviewService
    {
        private readonly IRepository<Review> ReviewRepository;

        public ReviewService(IRepository<Review> ReviewRepository)
        {
            this.ReviewRepository = ReviewRepository;
        }

        public void AddReview(string UserId, Guid VehicleId, int Stars, string ReviewText)
        {
            var review = new Review
            {
                UserId = UserId,
                VehicleId = VehicleId,
                Stars = Stars,
                ReviewText = ReviewText
            };
            ReviewRepository.Insert(review);
        }

        public void DeleteReview(Guid ReviewId)
        {
            var review = this.ReviewRepository.Get(ReviewId);
            this.ReviewRepository.Delete(review);
        }

        public void EditReview(Guid ReviewId, int Stars, string ReviewText)
        {
            var review = this.ReviewRepository.Get(ReviewId);
            review.Stars = Stars;
            review.ReviewText = ReviewText;
            ReviewRepository.Update(review);

        }

        public List<Review> GetAllReviewsForVehicle(Guid VehicleId)
        {
            return ReviewRepository.GetAll().Where(x => x.VehicleId == VehicleId).ToList();
        }

        public Review GetReviewForUserForVehicle(string UserId, Guid VehicleId)
        {
            return ReviewRepository.GetAll().Where(x => x.VehicleId == VehicleId).Where(x => x.UserId == UserId).FirstOrDefault();
        }
    }
}
