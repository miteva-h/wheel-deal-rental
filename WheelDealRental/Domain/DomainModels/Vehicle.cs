using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WheelDealRental.Domain.Relations;

namespace WheelDealRental.Domain.DomainModels
{
    public class Vehicle : BaseEntity
    {
        public string Registration { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public Color Color { get; set; }
        public Fuel Fuel { get; set; }
        public int Price { get; set; }
        public string Photo { get; set; }
        public virtual List<Dates> Dates { get; set; }
        public virtual Location Location { get; set; }
        public Guid LocationId { get; set; }
        public virtual ICollection<VehicleInShoppingCart> VehiclesInShoppingCart { get; set; }
        public virtual ICollection<VehicleInOrder> VehiclesInOrder { get; set; }
    }
}
