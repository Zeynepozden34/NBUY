﻿
using BlogApp.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EntityFramework.Mappings
{
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(r => r.Id); // PrimaryKey
            builder.Property(r => r.Id).ValueGeneratedOnAdd();

            builder.Property(r=>r.Name).IsRequired().HasMaxLength(30);

            builder.Property(r=>r.Description).IsRequired().HasMaxLength(250);

            builder.Property(r => r.CreatedByName).IsRequired().HasMaxLength(50);

            builder.Property(r => r.ModifiedByName).IsRequired().HasMaxLength(50);

            builder.Property(r => r.CreatedDate).IsRequired();

            builder.Property(r => r.ModifiedDate).IsRequired();
                
            builder.Property(r => r.IsActive).IsRequired();

            builder.Property(r => r.IsDeleted).IsRequired();

            builder.Property(r => r.Note).HasMaxLength(500);

            builder.ToTable("Roles");

            //Verinin içeriğini yukardaki propertylerden sonra yazmamız gerekir.
            //İlk rle verileri ekelneiyor.
            builder.HasData(
                new Role
                {
                    Id = 1,
                    Name = "Admin",
                    Description = "Admin Rolü tüm haklara sahiptir.",
                    IsActive = true,
                    IsDeleted=false, //Kalıcı olarak veriyi silmk için kullanacağımız metodun adı
                    CreatedByName="InitialCreate",
                    CreatedDate=DateTime.Now,
                    ModifiedByName="InitialCreated",
                    ModifiedDate=DateTime.Now,
                    Note="Bu admin rolüdür."
                },
                new Role
                {
                    Id = 2,
                    Name = "User",
                    Description = "User Rolü tüm haklara sahiptir.",
                    IsActive = true,
                    IsDeleted = false, //Kalıcı olarak veriyi silmk için kullanacağımız metodun adı
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreated",
                    ModifiedDate = DateTime.Now,
                    Note = "Bu user rolüdür."
                }
                ) ;
        }
    }
}
