using System;
using System.Collections.Generic;
using System.Text;
using WheelDealRental.Domain.Relations;

namespace WheelDealRental.Domain.DTO
{
    public class ShoppingCartDto:BaseEntity
    {
        public List<VehicleInShoppingCart> VehiclesInShoppingCart { get; set; }
        public double TotalPrice { get; set; }
    }
}
