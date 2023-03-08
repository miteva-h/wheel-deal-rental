using System;
using System.Collections.Generic;
using System.Text;
using WheelDealRental.Domain.DomainModels;

namespace WheelDealRental.Repository.Interface
{
    public interface IVehicleRepository
    {
        Vehicle GetVehicleWithLocation(Guid Id);
        List<Vehicle> GetAllVehiclesWithLocations();
        Vehicle GetVehicleWithDates(Guid Id);
    }
}
