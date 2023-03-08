using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WheelDealRentalUserApplication.Models
{
    public class Location
    {
        public string Name { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public DateTime Open { get; set; }
        public DateTime Close { get; set; }
        public List<Vehicle> Vehicles { get; set; }
    }
}
