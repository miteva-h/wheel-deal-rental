using System;
using System.Collections.Generic;
using System.Text;
using WheelDealRental.Domain.DTO;

namespace WheelDealRental.Service.Interface
{
    public interface IShoppingCartService
    {
        ShoppingCartDto GetShoppingCartInfo(string AppUserId);
        void DeleteVehicleFromShoppingCart(string AppUserId, Guid VehicleId);
        bool Order(string AppUserId);
    }
}
