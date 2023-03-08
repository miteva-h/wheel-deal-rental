using System;
using System.Collections.Generic;
using System.Text;

namespace WheelDealRental.Domain.DomainModels
{
    public class Dates:BaseEntity
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public Guid VehicleId { get; set; }

    }
}
