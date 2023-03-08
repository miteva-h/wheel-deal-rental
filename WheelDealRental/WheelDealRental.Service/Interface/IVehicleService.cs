using System;
using System.Collections.Generic;
using System.Text;
using WheelDealRental.Domain.DomainModels;

namespace WheelDealRental.Service.Interface
{
    public interface IVehicleService
    {
        List<Vehicle> GetAllVehicles();
        List<Vehicle> GetAllVehiclesWithLocations();
        Vehicle GetVehicle(Guid Id);
        Vehicle GetVehicleWithLocation(Guid Id);
        Vehicle GetVehicleWithDates(Guid Id);
        void AddNewVehicle(Guid LocationId, string Registration, string Brand, string Model, string Color, string Fuel, int Price, string Photo);
        void UpdateVehicle(Guid Id, Guid LocationId, int Price, string Photo);
        void DeleteVehicle(Guid Id);
        bool CheckIfAvailableDate(Guid Id, DateTime From, DateTime To);
        void TakeVehicle(Guid Id, DateTime From, DateTime To);
        void ReturnVehicle(Guid Id, DateTime From, DateTime To);
        void AddToShoppingCart(string AppUserId, Guid VehicleId, DateTime From, DateTime To);
    }
}
