using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WheelDealRental.Domain;
using WheelDealRental.Domain.DomainModels;
using WheelDealRental.Domain.DTO;
using WheelDealRental.Repository.Interface;
using WheelDealRental.Service.Interface;

namespace WheelDealRental.Web.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IOrderService orderService;

        public UserController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        [HttpGet("[action]")]
        public List<Order> GetActiveOrders()
        {
            var orders = this.orderService.GetAllOrders();
            return orders;
        }

        [HttpPost("[action]")]
        public List<Order> DeleteOrder(BaseEntity model)
        {
            this.orderService.DeleteOrder(model.Id);
            var result = this.orderService.GetAllOrders();
            return result;
        }
    }
}
