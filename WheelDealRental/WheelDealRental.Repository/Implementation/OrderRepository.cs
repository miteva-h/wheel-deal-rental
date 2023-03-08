using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WheelDealRental.Domain.DomainModels;
using WheelDealRental.Repository.Interface;

namespace WheelDealRental.Repository.Implementation
{
    public class OrderRepository:IOrderRepository
    {
        private readonly ApplicationDbContext ApplicationDbContext;
        private DbSet<Order> Orders;

        public OrderRepository(ApplicationDbContext ApplicationDbContext)
        {
            this.ApplicationDbContext = ApplicationDbContext;
            this.Orders = ApplicationDbContext.Set<Order>();
        }

        public List<Order> GetAllOrders()
        {
            return Orders
                .Include(z => z.AppUser)
                .Include(z => z.VehiclesInOrder)
                .Include("VehiclesInOrder.Vehicle")
                .Include("VehiclesInOrder.Vehicle.Location")
                .ToListAsync().Result;
        }

        public Order GetOrderDetails(Guid Id)
        {
            return Orders
                .Include(z => z.AppUser)
                .Include(z => z.VehiclesInOrder)
                .Include("VehiclesInOrder.Vehicle")
                .Include("VehiclesInOrder.Vehicle.Location")
                .SingleOrDefaultAsync(x => x.Id == Id).Result;
        }
    }
}
