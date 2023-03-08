using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WheelDealRental.Domain.DomainModels;

namespace WheelDealRental.Domain.Relations
{
    public class VehicleInShoppingCart : BaseEntity
    {
        public Guid VehicleId { get; set; }
        public Guid ShoppingCartId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
