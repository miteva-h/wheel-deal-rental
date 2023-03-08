using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WheelDealRentalUserApplication.Models
{
    public class Dates
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Vehicle Vehicle { get; set; }
        public Guid VehicleId { get; set; }
    }
}
