using System;
using System.Collections.Generic;
using System.Text;
using WheelDealRental.Domain.DomainModels;

namespace WheelDealRental.Service.Interface
{
    public interface IOrderService
    {
        public List<Order> GetAllOrders();
        public Order GetOrderDetails(Guid Id);
        public List<Order> GetAllOrdersForUser(string AppUserId);
        public void DeleteOrder(Guid Id);
    }
}
