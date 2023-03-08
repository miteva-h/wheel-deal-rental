using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WheelDealRentalUserApplication.Models
{
    public class Vehicle
    {
        public Guid Id { get; set; }
        public string Registration { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Color Color { get; set; }
        public Fuel Fuel { get; set; }
        public int Price { get; set; }
        public string Photo { get; set; }
        public List<Dates> Dates { get; set; }
        public Location Location { get; set; }
        public Guid LocationId { get; set; }
       
    }
}
