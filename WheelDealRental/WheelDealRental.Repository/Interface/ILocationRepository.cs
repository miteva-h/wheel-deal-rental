using System;
using System.Collections.Generic;
using System.Text;
using WheelDealRental.Domain.DomainModels;

namespace WheelDealRental.Repository.Interface
{
    public interface ILocationRepository
    {
        Location GetLocationWithVehicles(Guid Id);
    }
}
