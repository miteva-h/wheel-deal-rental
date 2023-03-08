using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WheelDealRental.Domain;
using WheelDealRental.Repository.Interface;

namespace WheelDealRental.Repository.Implementation
{
    public class Repository<T> : IRepository<T> where T:BaseEntity
    {
        private readonly ApplicationDbContext ApplicationDbContext;
        private DbSet<T> Entities;

        public Repository(ApplicationDbContext ApplicationDbContext)
        {
            this.ApplicationDbContext = ApplicationDbContext;
            this.Entities = ApplicationDbContext.Set<T>();
        }
        public void Delete(T Entity)
        {
            if (Entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            Entities.Remove(Entity);
            ApplicationDbContext.SaveChanges();
        }

        public T Get(Guid? Id)
        {
            return Entities
                .SingleOrDefault(s => s.Id == Id);
        }

        public IEnumerable<T> GetAll()
        {
            return Entities.AsEnumerable();
        }

        public void Insert(T Entity)
        {
            if (Entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            Entities.Add(Entity);
            ApplicationDbContext.SaveChanges();
        }

        public void Update(T Entity)
        {
            if (Entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            Entities.Update(Entity);
            ApplicationDbContext.SaveChanges();
        }
    }
}
