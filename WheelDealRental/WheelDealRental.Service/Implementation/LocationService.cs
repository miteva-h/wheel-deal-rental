using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WheelDealRental.Domain.DomainModels;
using WheelDealRental.Repository.Interface;
using WheelDealRental.Service.Interface;

namespace WheelDealRental.Service.Implementation
{
    public class LocationService : ILocationService
    {
        private readonly IRepository<Location> LocationRepository;
        private readonly ILocationRepository LocationRepositoryAdvanced;

        public LocationService(IRepository<Location> LocationRepository, ILocationRepository LocationRepositoryAdvanced)
        {
            this.LocationRepository = LocationRepository;
            this.LocationRepositoryAdvanced = LocationRepositoryAdvanced;
        }
        public Location AddNewLocation(string Name, string Street, string StreetNumber, DateTime Open, DateTime Close)
        {
            var location = new Location
            {
                Name = Name,
                Street = Street,
                StreetNumber = StreetNumber,
                Open = Open,
                Close = Close
            };
            LocationRepository.Insert(location);
            return location;
        }

        public void CloseLocation(Guid Id)
        {
             LocationRepository.Delete(GetLocation(Id));
        }

        public List<Location> GetAllLocations()
        {
            return LocationRepository.GetAll().ToList();
        }

        public List<Vehicle> GetAllVehiclesForLocation(Guid LocationId)
        {
            return GetLocation(LocationId).Vehicles;
        }

        public Location GetLocation(Guid Id)
        {
            return LocationRepositoryAdvanced.GetLocationWithVehicles(Id);
        }

        public Location UpdateLocation(Guid Id, string Name, string Street, string StreetNumber, DateTime Open, DateTime Close)
        {
            var toUpdate = GetLocation(Id);
            toUpdate.Name = Name;
            toUpdate.Street = Street;
            toUpdate.StreetNumber = StreetNumber;
            toUpdate.Open = Open;
            toUpdate.Close = Close;
            LocationRepository.Update(toUpdate);
            return toUpdate;
        }
    }
}
