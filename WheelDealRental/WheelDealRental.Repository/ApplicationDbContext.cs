using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WheelDealRental.Domain.DomainModels;
using WheelDealRental.Domain.Identity;
using WheelDealRental.Domain.Relations;

namespace WheelDealRental.Repository
{
    public class ApplicationDbContext : IdentityDbContext<ERentalUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Location> Locations { get; set; }
        public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public virtual DbSet<ERentalUser> AppUsers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<VehicleInShoppingCart> VehiclesInShoppingCarts { get; set; }
        public virtual DbSet<VehicleInOrder> VehiclesInOrder { get; set; }
        public virtual DbSet<Dates> Dates { get; set; }
        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<EmailMessage> EmailMessages { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //keys
            builder.Entity<Vehicle>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Location>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<ShoppingCart>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<VehicleInShoppingCart>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Order>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<VehicleInOrder>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Dates>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<Review>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<EmailMessage>()
                .Property(z => z.Id)
                .ValueGeneratedOnAdd();

            //enums
            builder.Entity<ERentalUser>()
                .Property(z => z.Role)
                .HasConversion<string>()
                .HasMaxLength(50);

            builder.Entity<Vehicle>()
                .Property(z => z.Color)
                .HasConversion<string>()
                .HasMaxLength(50);

            builder.Entity<Vehicle>()
                .Property(z => z.Fuel)
                .HasConversion<string>()
                .HasMaxLength(50);

            //one-to-many
            builder.Entity<Location>()
                .HasMany(x => x.Vehicles)
                .WithOne(x => x.Location)
                .HasForeignKey(x => x.Id);

            builder.Entity<Vehicle>()
                .HasOne(x => x.Location)
                .WithMany(x => x.Vehicles)
                .HasForeignKey(x => x.LocationId)
                .IsRequired();

            //one-to-many
            builder.Entity<ERentalUser>()
                .HasMany(x => x.Orders)
                .WithOne(x => x.AppUser)
                .HasForeignKey(x => x.Id);

            builder.Entity<Order>()
                .HasOne(x => x.AppUser)
                .WithMany(x => x.Orders)
                .HasForeignKey(x => x.UserId)
                .IsRequired();

            //one-to-many
            builder.Entity<Vehicle>()
                .HasMany(x => x.Dates)
                .WithOne(x => x.Vehicle)
                .HasForeignKey(x => x.Id);

            builder.Entity<Dates>()
                .HasOne(x => x.Vehicle)
                .WithMany(x => x.Dates)
                .HasForeignKey(x => x.VehicleId)
                .IsRequired();

            //many-to-many
            builder.Entity<VehicleInShoppingCart>()
                .HasOne(x => x.Vehicle)
                .WithMany(x => x.VehiclesInShoppingCart)
                .HasForeignKey(x => x.VehicleId)
                .IsRequired();

            builder.Entity<VehicleInShoppingCart>()
                .HasOne(x => x.ShoppingCart)
                .WithMany(x => x.VehiclesInShoppingCart)
                .HasForeignKey(x => x.ShoppingCartId)
                .IsRequired();


            //many-to-many
            builder.Entity<VehicleInOrder>()
                .HasOne(x => x.Order)
                .WithMany(x => x.VehiclesInOrder)
                .HasForeignKey(x => x.OrderId)
                .IsRequired();

            builder.Entity<VehicleInOrder>()
                .HasOne(x => x.Vehicle)
                .WithMany(x => x.VehiclesInOrder)
                .HasForeignKey(x => x.VehicleId)
                .IsRequired();

            //one-to-one
            builder.Entity<ShoppingCart>()
                .HasOne<ERentalUser>(x => x.AppUser)
                .WithOne(x => x.ShoppingCart)
                .HasForeignKey<ShoppingCart>(x => x.UserId)
                .IsRequired();



        }
    }
}
