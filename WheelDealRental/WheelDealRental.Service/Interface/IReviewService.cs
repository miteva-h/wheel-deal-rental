using System;
using System.Collections.Generic;
using System.Text;
using WheelDealRental.Domain.DomainModels;

namespace WheelDealRental.Service.Interface
{
    public interface IReviewService
    {
        List<Review> GetAllReviewsForVehicle(Guid VehicleId);
        Review GetReviewForUserForVehicle(string UserId, Guid VehicleId);
        void AddReview(string UserId, Guid VehicleId, int Stars, string ReviewText);
        void EditReview(Guid ReviewId, int Stars, string ReviewText);
        void DeleteReview(Guid ReviewId);

    }
}
