﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OzelDers.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OzelDers.Data.Config
{
    public class TeacherConfig : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
             builder.HasKey(t => t.Id);
            builder.Property(s => s.Id).ValueGeneratedOnAdd();

            builder.Property(t => t.UniverstyGraduatedFrom)
           .IsRequired()
           .HasMaxLength(100);

            builder.Property<int>(t => t.HourlyPrice)
              .IsRequired();

            builder.Property<bool>(t => t.IsFacetoFace)
                .IsRequired();

            builder.Property<bool>(t => t.CertifiedTrainer)
               .IsRequired();

            builder.Property(t => t.Email)
               .IsRequired()
               .HasMaxLength(75);

            builder.Property<int>(t => t.BrunchId)
             .IsRequired();

            builder.Property(t => t.FirstName)
                .IsRequired()
                .HasMaxLength(75);

            builder.Property(t => t.LastName)
             .IsRequired()
             .HasMaxLength(75);

            builder.Property(t => t.Description)
                .IsRequired();

            builder.Property<int>(t => t.Age)
                .IsRequired();

            builder.Property(t => t.Gender)
                .IsRequired()
                .HasMaxLength(5);

            builder.Property(t => t.ImageUrl)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(t => t.Location)
                .IsRequired()
                .HasMaxLength(200);

            builder.ToTable("Teachers");

            builder.HasData(
                new Teacher
                {
                    Id = 1,
                    UniverstyGraduatedFrom = "Cambridge University",
                    HourlyPrice = 800,
                    IsFacetoFace = false,
                    CertifiedTrainer = true,
                    Email = "jackbrand@ozelders.com",
                    BrunchId = 5,
                    FirstName = "Jack",
                    LastName = "Brand",
                    Description = "Engish lessons are given.",
                    Age = 27,
                    Gender = "erkek",
                    ImageUrl = "20.png",
                    Location = "Toronto/Canada"
                },
                new Teacher
                {
                    Id = 2,
                    UniverstyGraduatedFrom = "İstanbul Üniversitesi",
                    HourlyPrice = 400,
                    IsFacetoFace = true,
                    CertifiedTrainer = true,
                    Email = "sevgiozer@ozelders.com",
                    BrunchId = 2,
                    FirstName = "Sevgi",
                    LastName = "Özer",
                    Description = "Fizik dersi verilir.",
                    Age = 27,
                    Gender = "kadın",
                    ImageUrl = "21.png",
                    Location = "Avcılar/İstanbul"
                },

                new Teacher
                {
                    Id = 3,
                    UniverstyGraduatedFrom = "Haccettepe Üniversitesi",
                    HourlyPrice = 600,
                    IsFacetoFace = true,
                    CertifiedTrainer = true,
                    Email = "denizkuru@ozelders.com",
                    BrunchId = 1,
                    FirstName = "Deniz",
                    LastName = "Kuru",
                    Description = "Matematik dersi verilir.",
                    Age = 35,
                    Gender = "kadın",
                    ImageUrl = "22.png",
                    Location = "Avcılar/İstanbul"
                },

                new Teacher
                {
                    Id = 4,
                    UniverstyGraduatedFrom = "Marmara Üniversitesi",
                    HourlyPrice = 650,
                    IsFacetoFace = true,
                    CertifiedTrainer = true,
                    Email = "selimgoren@ozelders.com",
                    BrunchId = 3,
                    FirstName = "Selim",
                    LastName = "Gören",
                    Description = "Kimya dersi verilir.",
                    Age = 30,
                    Gender = "erkek",
                    ImageUrl = "23.png",
                    Location = "Çankaya/Ankara"
                },

                new Teacher
                {
                    Id = 5,
                    UniverstyGraduatedFrom = "Fırat Üniversitesi",
                    HourlyPrice = 400,
                    IsFacetoFace = true,
                    CertifiedTrainer = false,
                    Email = "kemaleren@ozelders.com",
                    BrunchId = 9,
                    FirstName = "Kemal",
                    LastName = "Eren",
                    Description = "C# dersi verilir.",
                    Age = 40,
                    Gender = "erkek",
                    ImageUrl = "24.png",
                    Location = "Bornova/İzmir"
                },

                new Teacher
                {
                    Id = 6,
                    UniverstyGraduatedFrom = "İstanbul Üniversitesi",
                    HourlyPrice = 600,
                    IsFacetoFace = true,
                    CertifiedTrainer = true,
                    Email = "melissusan@ozelders.com",
                    BrunchId = 6,
                    FirstName = "Melis",
                    LastName = "Susan",
                    Description = "Edebiyat dersi verilir.",
                    Age = 25,
                    Gender = "kadın",
                    ImageUrl = "25.png",
                    Location = "Sefaköy/İstanbul"
                },
                new Teacher
                {
                    Id = 7,
                    UniverstyGraduatedFrom = "Dokuz Eylül Üniversitesi",
                    HourlyPrice = 500,
                    IsFacetoFace = false,
                    CertifiedTrainer = true,
                    Email = "defnebilen@ozelders.com",
                    BrunchId = 8,
                    FirstName = "Defne",
                    LastName = "Bilen",
                    Description = "Almanca dersi verilir.",
                    Age = 34,
                    Gender = "kadın",
                    ImageUrl = "26.png",
                    Location = "Buca/İzmir"
                }
                );
        }
    }
}
