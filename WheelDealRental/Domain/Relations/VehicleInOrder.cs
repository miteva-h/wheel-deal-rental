using System;
using System.Collections.Generic;
using System.Text;
using WheelDealRental.Domain.DomainModels;

namespace WheelDealRental.Domain.Relations
{
    public class VehicleInOrder : BaseEntity
    {
        public Guid VehicleId { get; set; }
        public Guid OrderId { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual Order Order { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
