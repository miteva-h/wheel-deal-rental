using System;
using System.Collections.Generic;
using System.Text;
using WheelDealRental.Domain.Relations;

namespace WheelDealRental.Repository.Interface
{
    public interface IVehicleInShoppingCartRepository
    {
        List<VehicleInShoppingCart> GetAllVehiclesWithLocations();
    }
}
