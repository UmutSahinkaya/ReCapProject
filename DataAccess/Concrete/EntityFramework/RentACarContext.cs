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
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDb;Database=RentACar,Trusted_Connection=true");
        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
       
    }
}
