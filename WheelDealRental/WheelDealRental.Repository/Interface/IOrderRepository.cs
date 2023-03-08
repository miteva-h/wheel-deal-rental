using System;
using System.Collections.Generic;
using System.Text;
using WheelDealRental.Domain.DomainModels;

namespace WheelDealRental.Repository.Interface
{
    public interface IOrderRepository
    {
        Order GetOrderDetails(Guid Id);
        List<Order> GetAllOrders();
        
    }
}
