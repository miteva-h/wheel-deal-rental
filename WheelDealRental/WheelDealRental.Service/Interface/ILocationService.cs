using System;
using System.Collections.Generic;
using System.Text;
using WheelDealRental.Domain.DomainModels;

namespace WheelDealRental.Service.Interface
{
    public interface ILocationService
    {
        List<Location> GetAllLocations();
        Location GetLocation(Guid Id);
        Location AddNewLocation(string Name, string Street, string StreetNumber, DateTime Open, DateTime Close);
        Location UpdateLocation(Guid Id, string Name, string Street, string StreetNumber, DateTime Open, DateTime Close);
        void CloseLocation(Guid Id);
        List<Vehicle> GetAllVehiclesForLocation(Guid LocationId);
    }
}
