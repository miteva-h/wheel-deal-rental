using System;
using System.Collections.Generic;
using System.Text;

namespace WheelDealRental.Domain.DomainModels
{
    public class Review:BaseEntity
    {
        public string UserId { get; set; }
        public Guid VehicleId { get; set; }
        public int Stars { get; set; }
        public string ReviewText { get; set; }
    }
}
