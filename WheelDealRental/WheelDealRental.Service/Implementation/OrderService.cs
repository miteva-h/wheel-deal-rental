using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using WheelDealRental.Domain.DomainModels;
using WheelDealRental.Repository.Interface;
using WheelDealRental.Service.Interface;

namespace WheelDealRental.Service.Implementation
{
    public class OrderService : IOrderService
    {
        private readonly IRepository<Order> OrderRepository;
        private readonly IOrderRepository OrderRepositoryAdvanced;
        private readonly IVehicleService vehicleService;

        public OrderService(IRepository<Order> OrderRepository, IOrderRepository OrderRepositoryAdvanced, IVehicleService vehicleService)
        {
            this.OrderRepository = OrderRepository;
            this.OrderRepositoryAdvanced = OrderRepositoryAdvanced;
            this.vehicleService = vehicleService;
        }
        public List<Order> GetAllOrders()
        {
            return OrderRepository.GetAll().ToList();
        }

        public List<Order> GetAllOrdersForUser(string AppUserId)
        {
            return OrderRepository.GetAll().Where(x => x.UserId==AppUserId).ToList();
        }

        public Order GetOrderDetails(Guid Id)
        {
            return OrderRepositoryAdvanced.GetOrderDetails(Id);
        }

        public void DeleteOrder(Guid Id)
        {
            Order order = this.GetOrderDetails(Id);
            foreach(var v in order.VehiclesInOrder)
            {
                vehicleService.ReturnVehicle(v.VehicleId, v.From, v.To);
            }
            this.OrderRepository.Delete(order);
            
        }
    }
}
