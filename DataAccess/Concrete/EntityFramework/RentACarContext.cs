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
        protected override void OnModelCreating(ModelBuilder modelBuilder)
       {
           modelBuilder.Entity<Car>().ToTable("Cars");
           modelBuilder.Entity<Car>().Property(c => c.Id).HasColumnName("Id");
           modelBuilder.Entity<Car>().Property(c => c.BrandId).HasColumnName("brand_id");
           modelBuilder.Entity<Car>().Property(c => c.ColorId).HasColumnName("color_id");
           modelBuilder.Entity<Car>().Property(c => c.ModelYear).HasColumnName("model_year");
           modelBuilder.Entity<Car>().Property(c => c.DailyPrice).HasColumnName("daily_price");
           modelBuilder.Entity<Car>().Property(c => c.Description).HasColumnName("description");
           modelBuilder.Entity<Brand>().ToTable("Brands");
           modelBuilder.Entity<Brand>().Property(b => b.BrandId).HasColumnName("brand_id");
           modelBuilder.Entity<Brand>().Property(b => b.BrandName).HasColumnName("brand_name");
           modelBuilder.Entity<Color>().Property(co => co.ColorId).HasColumnName("color_id");
           modelBuilder.Entity<Color>().Property(co => co.ColorName).HasColumnName("color_name");

        }
    }
}
