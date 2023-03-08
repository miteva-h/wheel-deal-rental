using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WheelDealRental.Domain.DomainModels;
using WheelDealRental.Repository.Interface;

namespace WheelDealRental.Repository.Implementation
{
    public class LocationRepository : ILocationRepository
    {
        private readonly ApplicationDbContext ApplicationDbContext;
        private DbSet<Location> Locations;
        public LocationRepository(ApplicationDbContext ApplicationDbContext)
        {
            this.ApplicationDbContext = ApplicationDbContext;
            this.Locations = ApplicationDbContext.Set<Location>();
        }
        public Location GetLocationWithVehicles(Guid Id)
        {
            return Locations
                .Include(x => x.Vehicles)
                .SingleOrDefaultAsync(x => x.Id == Id).Result;
        }
    }
}
