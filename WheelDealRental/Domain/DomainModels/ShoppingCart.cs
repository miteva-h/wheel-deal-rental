using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WheelDealRental.Domain;
using WheelDealRental.Domain.Identity;
using WheelDealRental.Domain.Relations;

namespace WheelDealRental.Domain.DomainModels
{ 
    public class ShoppingCart : BaseEntity
    {
        public virtual ERentalUser AppUser { get; set; }
        public string UserId { get; set; }
        public virtual ICollection<VehicleInShoppingCart> VehiclesInShoppingCart { get; set; }
        
    }
}
