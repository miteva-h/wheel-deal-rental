using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WheelDealRental.Domain.Relations;
using WheelDealRental.Repository.Interface;

namespace WheelDealRental.Repository.Implementation
{
    public class VehicleInShoppingCartRepository : IVehicleInShoppingCartRepository
    {
        private readonly ApplicationDbContext ApplicationDbContext;
        private DbSet<VehicleInShoppingCart> VehiclesInShoppingCart;

        public VehicleInShoppingCartRepository(ApplicationDbContext ApplicationDbContext)
        {
            this.ApplicationDbContext = ApplicationDbContext;
            this.VehiclesInShoppingCart = ApplicationDbContext.Set<VehicleInShoppingCart>();
        }
        public List<VehicleInShoppingCart> GetAllVehiclesWithLocations()
        {
            return VehiclesInShoppingCart
                .Include(x => x.Vehicle)
                .Include(x => x.Vehicle.Location)
                .ToListAsync().Result;
        }
    }
}
