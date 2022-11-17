using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Proje05_MVC_EfCore_CodeFirst.Models
{
    //dotnet ef database update bu komutla burada yapılan değişiklikler veritabanına aktarır. olmayan veriyi aktarmak için dotnet ef migrations add InitalDb ardından dotnet ef database update diyoruz. veritabanına eni bir model eklemek için  dotnet ef migrations add model adını yazıp ardından dotnet ef database update diyoruz.
    public class MyDbContext :DbContext
    {
        public DbSet<Category> Categories { get; set; }     
        public DbSet<Product> Products { get; set; }
        public DbSet<City> Citys { get; set; }
        
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //override cs'de metotları ezer yeni metot üretir.
        {
            optionsBuilder.UseSqlite("Data Source=First.Db"); //bu isimli veritabanını getirir.
        }
    
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()   //veritabanında category tablosundan bahsetmiş luruzve burada category'e veri ekleyebiliriz.
            .HasData(
                new Category(){Id=1, Name="Phone", Desc="Phones"},
                new Category(){Id=2, Name="Cumputer", Desc="Computers"},
                new Category(){Id=3, Name="Electronic", Desc="Electronics"}
            );

            modelBuilder.Entity<Product>()
            .HasData(
                new Product(){Id=1, Name="Iphone 13", Desc="Güzwl teledon", Price=19000, CategoryId=1},
                new Product(){Id=2, Name="Dell Xs", Desc="Güzwl PC", Price=29000, CategoryId=2},
                new Product(){Id=3, Name="Samsung A71", Desc="Güzwl camera", Price=15000, CategoryId=1},
                new Product(){Id=4, Name="Piranha X13", Desc="Güzwl ses", Price=24000, CategoryId=3}         
            );
             modelBuilder.Entity<City>()
            .HasData(
                new City(){Id=34, Name="İstanbul"},
                new City(){Id=35, Name="İzmir"},
                new City(){Id=18, Name="Çanakkale"}     
            );
        }
    }
}