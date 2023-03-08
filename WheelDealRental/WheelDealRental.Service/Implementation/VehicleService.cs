using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WheelDealRental.Domain.DomainModels;
using WheelDealRental.Domain.Relations;
using WheelDealRental.Repository.Interface;
using WheelDealRental.Service.Interface;

namespace WheelDealRental.Service.Implementation
{
    public class VehicleService : IVehicleService
    {
        private readonly IRepository<Vehicle> VehicleRepository;
        private readonly IRepository<Dates> DatesRepository;
        private readonly IVehicleRepository VehicleRepositoryAdvanced;
        private readonly IUserRepository UserRepository;
        private readonly IRepository<VehicleInShoppingCart> VehicleInShoppingCartRepository;
        

        public VehicleService(IRepository<Vehicle> VehicleRepository, 
            IUserRepository UserRepository, 
            IRepository<VehicleInShoppingCart> VehicleInShoppingCartRepository,
            IVehicleRepository VehicleRepositoryAdvanced,
            IRepository<Dates> DatesRepository)
        {
            this.VehicleRepository = VehicleRepository;
            this.UserRepository = UserRepository;
            this.VehicleInShoppingCartRepository = VehicleInShoppingCartRepository;
            this.VehicleRepositoryAdvanced = VehicleRepositoryAdvanced;
            this.DatesRepository = DatesRepository;
        }

        public void AddNewVehicle(Guid LocationId, string Registration, string Brand, string Model, string Color, string Fuel, int Price, string Photo)
        {
            Enum.TryParse(Color, out Color color);
            Enum.TryParse(Fuel, out Fuel fuel);
            VehicleRepository.Insert(new Vehicle
            {
                Registration = Registration,
                Brand = Brand,
                Model = Model,
                Color = color,
                Fuel = fuel,
                Price = Price,
                Photo = Photo,
                //Dates = new List<Dates>(),
                LocationId = LocationId
            });
        }

        public void AddToShoppingCart(string AppUserId, Guid VehicleId, DateTime From, DateTime To)
        {
            var shoppingCart = UserRepository.Get(AppUserId).ShoppingCart;
            var shoppingCartContent = shoppingCart.VehiclesInShoppingCart;
            
            
                var itemToAdd = new VehicleInShoppingCart
                {   
                    VehicleId = VehicleId, 
                    Vehicle = GetVehicleWithLocation(VehicleId), 
                    ShoppingCartId = shoppingCart.Id, 
                    ShoppingCart = shoppingCart, 
                    From = From,
                    To = To
                };
                VehicleInShoppingCartRepository.Insert(itemToAdd);
                TakeVehicle(VehicleId, From, To);
            
        }

        public bool CheckIfAvailableDate(Guid Id, DateTime From, DateTime To)
        {
            var vehicle = VehicleRepositoryAdvanced.GetVehicleWithDates(Id);
            
                if (vehicle.Dates!=null)
            {
                foreach (Dates x in vehicle.Dates.ToList())
                {
                    for (DateTime dt = From; dt <= To; dt = dt.AddDays(1))
                    {
                        if (dt.Date >= x.From.Date && dt.Date <= x.To.Date)
                        {
                            return false;
                        }
                    }

                }
            }
            return true;
        }

        public void DeleteVehicle(Guid Id)
        {
            var toDelete = GetVehicle(Id);
            VehicleRepository.Delete(toDelete);
        }

        public List<Vehicle> GetAllVehicles()
        {
            return VehicleRepository.GetAll().ToList();
        }

        public List<Vehicle> GetAllVehiclesWithLocations()
        {
            return VehicleRepositoryAdvanced.GetAllVehiclesWithLocations();
        }

        public Vehicle GetVehicle(Guid Id)
        {
            return VehicleRepository.Get(Id);
        }

        public Vehicle GetVehicleWithDates(Guid Id)
        {
            return VehicleRepositoryAdvanced.GetVehicleWithDates(Id);
        }

        public Vehicle GetVehicleWithLocation(Guid Id)
        {
            return VehicleRepositoryAdvanced.GetVehicleWithLocation(Id);
        }

        public void ReturnVehicle(Guid Id, DateTime From, DateTime To)
        {
            var vehicle = VehicleRepositoryAdvanced.GetVehicleWithDates(Id);
            foreach (Dates x in vehicle.Dates.ToList())
            {
                if (x.From.Date == From.Date && x.To.Date == To.Date)
                {
                    DatesRepository.Delete(x);
                    
                }

            }
            VehicleRepository.Update(vehicle);
        }

        public void TakeVehicle(Guid Id, DateTime From, DateTime To)
        {
            if (CheckIfAvailableDate(Id, From, To))
            {
                var vehicle = GetVehicle(Id);
                DatesRepository.Insert(new Dates
                {
                    From = From,
                    To = To,
                    VehicleId = Id
                });
                VehicleRepository.Update(vehicle);
            }
        }

        public void UpdateVehicle(Guid Id, Guid LocationId, int Price, string Photo)
        {
            var toUpdate = GetVehicleWithLocation(Id);
            toUpdate.LocationId = LocationId;
            toUpdate.Price = Price;
            toUpdate.Photo = Photo;
            VehicleRepository.Update(toUpdate);
        }
    }
}
