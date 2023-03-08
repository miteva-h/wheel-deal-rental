using System;
using System.Collections.Generic;
using System.Text;
using WheelDealRental.Domain.Identity;

namespace WheelDealRental.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<ERentalUser> GetAll();
        ERentalUser Get(string Id);
        void Insert(ERentalUser Entity);
        void Update(ERentalUser Entity);
        void Delete(ERentalUser Entity);
    }
}
