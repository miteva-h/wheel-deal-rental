using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WheelDealRental.Domain.DomainModels;

namespace WheelDealRental.Domain.Identity
{
    public class ERentalUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Role Role { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
        public virtual List<Order> Orders { get; set; }
    }
}
