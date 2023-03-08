using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WheelDealRental.Domain.DomainModels;

namespace WheelDealRental.Domain.DTO
{
    public class AddToShoppingCartDto:BaseEntity
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public Vehicle SelectedVehicle { get; set; }
        public Guid SelectedVehicleId { get; set; }
    }
}
