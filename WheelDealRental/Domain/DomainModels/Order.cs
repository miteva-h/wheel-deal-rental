using System;
using System.Collections.Generic;
using System.Text;
using WheelDealRental.Domain.Identity;
using WheelDealRental.Domain.Relations;

namespace WheelDealRental.Domain.DomainModels
{
    public class Order:BaseEntity
    {
        public virtual ERentalUser AppUser { get; set; }
        public string UserId { get; set; }
        public virtual ICollection<VehicleInOrder> VehiclesInOrder{ get; set; }
        public double TotalPrice { get; set; }

    }
}
