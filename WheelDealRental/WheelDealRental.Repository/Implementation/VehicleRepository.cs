using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WheelDealRental.Domain.DomainModels;
using WheelDealRental.Repository.Interface;

namespace WheelDealRental.Repository.Implementation
{
    public class VehicleRepository:IVehicleRepository
    {
        private readonly ApplicationDbContext ApplicationDbContext;
        private DbSet<Vehicle> Vehicles;

        public VehicleRepository(ApplicationDbContext ApplicationDbContext)
        {
            this.ApplicationDbContext = ApplicationDbContext;
            this.Vehicles = ApplicationDbContext.Set<Vehicle>();
        }

        public List<Vehicle> GetAllVehiclesWithLocations()
        {
            return Vehicles
                .Include(x => x.Location)
                .ToListAsync().Result;
        }

        public Vehicle GetVehicleWithDates(Guid Id)
        {
            return Vehicles
                .Include(x => x.Dates)
                .SingleOrDefaultAsync(x => x.Id == Id).Result;
        }

        public Vehicle GetVehicleWithLocation(Guid Id)
        {
            return Vehicles
                .Include(x => x.Location)
                .SingleOrDefaultAsync(x => x.Id == Id).Result;
        }
    }
}
