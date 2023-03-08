using System;
using System.Collections.Generic;
using System.Text;
using WheelDealRental.Domain;

namespace WheelDealRental.Repository.Interface
{
    public interface IRepository<T> where T:BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(Guid? Id);
        void Insert(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
    }
}
