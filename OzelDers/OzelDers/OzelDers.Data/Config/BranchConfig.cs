using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OzelDers.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Data.Config
{
    public class BranchConfig:IEntityTypeConfiguration<Branch>
    {
        public void Configure(EntityTypeBuilder<Branch> builder) 
        { 
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).ValueGeneratedOnAdd();


            builder.Property(b => b.Name)
            .IsRequired()
            .HasMaxLength(100);


            builder.ToTable("Branchs");
            builder.HasData(
                new Branch { Id = 1, Name = "Matematik" },
                new Branch { Id = 2, Name = "Fizik" },
                new Branch { Id = 3, Name = "Kimya" },
                new Branch { Id = 4, Name = "Tarih" },
                new Branch { Id = 5, Name = "İngilizce" },
                new Branch { Id = 6, Name = "Edebiyat" },
                new Branch { Id = 7, Name = "Biyoloji" },
                new Branch { Id = 8, Name = "Almanca" },
                new Branch { Id = 9, Name = "C#" },
                new Branch { Id = 10, Name = "Felsefe" }
                );
        }
    }
}
