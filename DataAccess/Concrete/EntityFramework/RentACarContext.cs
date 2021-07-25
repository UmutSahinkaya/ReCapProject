using System;
using System.Collections.Generic;
using System.Text;
using Entitiy.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    //Burası bizim filtreler yazmamızı sağlıyor. Misal Ürünleri fiyata göre listele veya İndirim miktarına göre listele vs
    public class RentACarContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=RentACar;Trusted_Connection=true");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
           modelBuilder.Entity<Car>().ToTable("Cars");
           modelBuilder.Entity<Car>().Property(c => c.Id).HasColumnName("Id");
           modelBuilder.Entity<Car>().Property(c => c.BrandId).HasColumnName("brand_id");
           modelBuilder.Entity<Car>().Property(c => c.ColorId).HasColumnName("color_id");
           modelBuilder.Entity<Car>().Property(c => c.ModelYear).HasColumnName("model_year");
           modelBuilder.Entity<Car>().Property(c => c.DailyPrice).HasColumnName("daily_price");
           modelBuilder.Entity<Car>().Property(c => c.Description).HasColumnName("description");
           //Car to End
           modelBuilder.Entity<Brand>().ToTable("Brands");
           modelBuilder.Entity<Brand>().Property(b => b.BrandId).HasColumnName("brand_id");
           modelBuilder.Entity<Brand>().Property(b => b.BrandName).HasColumnName("brand_name");
           //Brand to End
           modelBuilder.Entity<Color>().Property(co => co.ColorId).HasColumnName("color_id");
           modelBuilder.Entity<Color>().Property(co => co.ColorName).HasColumnName("color_name");
            //Color to End
            modelBuilder.Entity<User>().Property(u => u.UserId).HasColumnName("user_id");
            modelBuilder.Entity<User>().Property(u => u.FirstName).HasColumnName("first_name");
            modelBuilder.Entity<User>().Property(u => u.LastName).HasColumnName("last_name");
            modelBuilder.Entity<User>().Property(u => u.Email).HasColumnName("email");
            modelBuilder.Entity<User>().Property(u => u.Password).HasColumnName("password");
            //User to End
            modelBuilder.Entity<Rental>().Property(re => re.RentalId).HasColumnName("rental_id");
            modelBuilder.Entity<Rental>().Property(re => re.CarId).HasColumnName("car_id");
            modelBuilder.Entity<Rental>().Property(re => re.CustomerId).HasColumnName("customer_id");
            modelBuilder.Entity<Rental>().Property(re => re.RentDate).HasColumnName("rent_date");
            modelBuilder.Entity<Rental>().Property(re => re.ReturnDate).HasColumnName("return_date");
            //Customer to End
            modelBuilder.Entity<Customer>().Property(cu => cu.CustomerId).HasColumnName("customer_id");
            modelBuilder.Entity<Customer>().Property(cu => cu.UserId).HasColumnName("user_id");
            modelBuilder.Entity<Customer>().Property(cu => cu.CompanyName).HasColumnName("company_name");

        }
    }
}
