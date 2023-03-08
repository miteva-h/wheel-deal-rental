using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WheelDealRental.Domain.Identity;
using WheelDealRental.Repository.Interface;

namespace WheelDealRental.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext ApplicationDbContext;
        private DbSet<ERentalUser> AppUsers;

        public UserRepository(ApplicationDbContext ApplicationDbContext)
        {
            this.ApplicationDbContext = ApplicationDbContext;
            this.AppUsers = ApplicationDbContext.Set<ERentalUser>();
        }
        public void Delete(ERentalUser Entity)
        {
            if (Entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            AppUsers.Remove(Entity);
            ApplicationDbContext.SaveChanges();
        }

        public ERentalUser Get(string Id)
        {
            return AppUsers
                .Include(z => z.ShoppingCart)
                .Include("ShoppingCart.VehiclesInShoppingCart")
                .Include("ShoppingCart.VehiclesInShoppingCart.Vehicle")
                .SingleOrDefault(s => s.Id == Id);
        }

        public IEnumerable<ERentalUser> GetAll()
        {
            return AppUsers.AsEnumerable();
        }

        public void Insert(ERentalUser Entity)
        {
            if (Entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            AppUsers.Add(Entity);
            ApplicationDbContext.SaveChanges();
        }

        public void Update(ERentalUser Entity)
        {
            if (Entity == null)
            {
                throw new ArgumentNullException("Entity");
            }
            AppUsers.Update(Entity);
            ApplicationDbContext.SaveChanges();
        }
    }
}
