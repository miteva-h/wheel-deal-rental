using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WheelDealRentalUserApplication.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public ERentalUser AppUser { get; set; }
        public string UserId { get; set; }
        public ICollection<VehicleInOrder> VehiclesInOrder { get; set; }
        public double TotalPrice { get; set; }
    }
}
