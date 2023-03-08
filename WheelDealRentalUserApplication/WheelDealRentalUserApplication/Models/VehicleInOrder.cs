using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WheelDealRentalUserApplication.Models
{
    public class VehicleInOrder
    {
        public Guid VehicleId { get; set; }
        public Guid OrderId { get; set; }
        public Vehicle Vehicle { get; set; }
        public Order Order { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}

