﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OzelDers.Data.Concrete.EfCore.Contexts;

#nullable disable

namespace OzelDers.Data.Migrations
{
    [DbContext(typeof(OzelDersContext))]
    [Migration("20230105072300_InitialDb")]
    partial class InitialDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("OzelDers.Entity.Concrete.Branch", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Branchs", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Matematik"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Fizik"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Kimya"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Tarih"
                        },
                        new
                        {
                            Id = 5,
                            Name = "İngilizce"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Edebiyat"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Biyoloji"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Almanca"
                        },
                        new
                        {
                            Id = 9,
                            Name = "C#"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Felsefe"
                        });
                });

            modelBuilder.Entity("OzelDers.Entity.Concrete.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 17,
                            Description = "Lise Öğrencisi",
                            FirstName = "Selim",
                            Gender = "erkek",
                            ImageUrl = "1.png",
                            IsDeleted = false,
                            LastName = "Durmuş",
                            Location = "Üsküdar/İstanbul"
                        },
                        new
                        {
                            Id = 2,
                            Age = 18,
                            Description = "Üniversite Hazırlık Öğrencisi",
                            FirstName = "Defne",
                            Gender = "kız",
                            ImageUrl = "2.png",
                            IsDeleted = false,
                            LastName = "Görmüş",
                            Location = "Çankaya/Ankara"
                        },
                        new
                        {
                            Id = 3,
                            Age = 21,
                            Description = "Üniversite Öğrencisi",
                            FirstName = "Hazal",
                            Gender = "kız",
                            ImageUrl = "3.png",
                            IsDeleted = false,
                            LastName = "Kara",
                            Location = "Çukurova/Adana"
                        },
                        new
                        {
                            Id = 4,
                            Age = 23,
                            Description = "Üniversite Öğrencisi",
                            FirstName = "Gözde",
                            Gender = "kız",
                            ImageUrl = "4.png",
                            IsDeleted = false,
                            LastName = "Kama",
                            Location = "Bahçelievler/İstanbul"
                        },
                        new
                        {
                            Id = 5,
                            Age = 17,
                            Description = "Lise Öğrencisi",
                            FirstName = "Hüseyin",
                            Gender = "erkek",
                            ImageUrl = "5.png",
                            IsDeleted = false,
                            LastName = "Kazanmış",
                            Location = "Küçükçekmece/İstanbul"
                        },
                        new
                        {
                            Id = 6,
                            Age = 16,
                            Description = "Lise Öğrencisi",
                            FirstName = "Bilal",
                            Gender = "erkek",
                            ImageUrl = "6.png",
                            IsDeleted = false,
                            LastName = "Telli",
                            Location = "Bornova/İzmir"
                        },
                        new
                        {
                            Id = 7,
                            Age = 15,
                            Description = "Lise Öğrencisi",
                            FirstName = "Yunus",
                            Gender = "erkek",
                            ImageUrl = "7.png",
                            IsDeleted = false,
                            LastName = "Deniz",
                            Location = "İzmit/Kocaeli"
                        },
                        new
                        {
                            Id = 8,
                            Age = 18,
                            Description = "Üniversite Hazırlık Öğrencisi",
                            FirstName = "Cemre",
                            Gender = "erkek",
                            ImageUrl = "8.png",
                            IsDeleted = false,
                            LastName = "Kıran",
                            Location = "Üsküdar/İstanbul"
                        },
                        new
                        {
                            Id = 9,
                            Age = 19,
                            Description = "Üniversite Öğrencisi",
                            FirstName = "Yusuf",
                            Gender = "erkek",
                            ImageUrl = "9.png",
                            IsDeleted = false,
                            LastName = "Güzel",
                            Location = "Yüreğir/Adana"
                        },
                        new
                        {
                            Id = 10,
                            Age = 19,
                            Description = "Üniversite Öğrencisi",
                            FirstName = "Harun",
                            Gender = "erkek",
                            ImageUrl = "10.png",
                            IsDeleted = false,
                            LastName = "Bulut",
                            Location = "İskenderun/Hatay"
                        },
                        new
                        {
                            Id = 11,
                            Age = 20,
                            Description = "Üniversite Öğrencisi",
                            FirstName = "Yıldız",
                            Gender = "kız",
                            ImageUrl = "11.png",
                            IsDeleted = false,
                            LastName = "Mutlu",
                            Location = "Pendik/İstanbul"
                        });
                });

            modelBuilder.Entity("OzelDers.Entity.Concrete.StudentAndTeacher", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeacherId")
                        .HasColumnType("INTEGER");

                    b.HasKey("StudentId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("StudentAndTeachers");

                    b.HasData(
                        new
                        {
                            StudentId = 1,
                            TeacherId = 1
                        },
                        new
                        {
                            StudentId = 2,
                            TeacherId = 2
                        },
                        new
                        {
                            StudentId = 3,
                            TeacherId = 2
                        },
                        new
                        {
                            StudentId = 4,
                            TeacherId = 3
                        },
                        new
                        {
                            StudentId = 5,
                            TeacherId = 4
                        },
                        new
                        {
                            StudentId = 6,
                            TeacherId = 5
                        },
                        new
                        {
                            StudentId = 7,
                            TeacherId = 6
                        },
                        new
                        {
                            StudentId = 8,
                            TeacherId = 1
                        },
                        new
                        {
                            StudentId = 9,
                            TeacherId = 3
                        });
                });

            modelBuilder.Entity("OzelDers.Entity.Concrete.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BranchId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BrunchId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CertifiedTrainer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("TEXT");

                    b.Property<int>("HourlyPrice")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsFacetoFace")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("TEXT");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("TEXT");

                    b.Property<string>("UniverstyGraduatedFrom")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BranchId");

                    b.ToTable("Teachers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 27,
                            BrunchId = 5,
                            CertifiedTrainer = true,
                            Description = "Engish lessons are given.",
                            Email = "jackbrand@ozelders.com",
                            FirstName = "Jack",
                            Gender = "erkek",
                            HourlyPrice = 800,
                            ImageUrl = "20.png",
                            IsDeleted = false,
                            IsFacetoFace = false,
                            LastName = "Brand",
                            Location = "Toronto/Canada",
                            UniverstyGraduatedFrom = "Cambridge University"
                        },
                        new
                        {
                            Id = 2,
                            Age = 27,
                            BrunchId = 2,
                            CertifiedTrainer = true,
                            Description = "Fizik dersi verilir.",
                            Email = "sevgiozer@ozelders.com",
                            FirstName = "Sevgi",
                            Gender = "kadın",
                            HourlyPrice = 400,
                            ImageUrl = "21.png",
                            IsDeleted = false,
                            IsFacetoFace = true,
                            LastName = "Özer",
                            Location = "Avcılar/İstanbul",
                            UniverstyGraduatedFrom = "İstanbul Üniversitesi"
                        },
                        new
                        {
                            Id = 3,
                            Age = 35,
                            BrunchId = 1,
                            CertifiedTrainer = true,
                            Description = "Matematik dersi verilir.",
                            Email = "denizkuru@ozelders.com",
                            FirstName = "Deniz",
                            Gender = "kadın",
                            HourlyPrice = 600,
                            ImageUrl = "22.png",
                            IsDeleted = false,
                            IsFacetoFace = true,
                            LastName = "Kuru",
                            Location = "Avcılar/İstanbul",
                            UniverstyGraduatedFrom = "Haccettepe Üniversitesi"
                        },
                        new
                        {
                            Id = 4,
                            Age = 30,
                            BrunchId = 3,
                            CertifiedTrainer = true,
                            Description = "Kimya dersi verilir.",
                            Email = "selimgoren@ozelders.com",
                            FirstName = "Selim",
                            Gender = "erkek",
                            HourlyPrice = 650,
                            ImageUrl = "23.png",
                            IsDeleted = false,
                            IsFacetoFace = true,
                            LastName = "Gören",
                            Location = "Çankaya/Ankara",
                            UniverstyGraduatedFrom = "Marmara Üniversitesi"
                        },
                        new
                        {
                            Id = 5,
                            Age = 40,
                            BrunchId = 9,
                            CertifiedTrainer = false,
                            Description = "C# dersi verilir.",
                            Email = "kemaleren@ozelders.com",
                            FirstName = "Kemal",
                            Gender = "erkek",
                            HourlyPrice = 400,
                            ImageUrl = "24.png",
                            IsDeleted = false,
                            IsFacetoFace = true,
                            LastName = "Eren",
                            Location = "Bornova/İzmir",
                            UniverstyGraduatedFrom = "Fırat Üniversitesi"
                        },
                        new
                        {
                            Id = 6,
                            Age = 25,
                            BrunchId = 6,
                            CertifiedTrainer = true,
                            Description = "Edebiyat dersi verilir.",
                            Email = "melissusan@ozelders.com",
                            FirstName = "Melis",
                            Gender = "kadın",
                            HourlyPrice = 600,
                            ImageUrl = "25.png",
                            IsDeleted = false,
                            IsFacetoFace = true,
                            LastName = "Susan",
                            Location = "Sefaköy/İstanbul",
                            UniverstyGraduatedFrom = "İstanbul Üniversitesi"
                        },
                        new
                        {
                            Id = 7,
                            Age = 34,
                            BrunchId = 8,
                            CertifiedTrainer = true,
                            Description = "Almanca dersi verilir.",
                            Email = "defnebilen@ozelders.com",
                            FirstName = "Defne",
                            Gender = "kadın",
                            HourlyPrice = 500,
                            ImageUrl = "26.png",
                            IsDeleted = false,
                            IsFacetoFace = false,
                            LastName = "Bilen",
                            Location = "Buca/İzmir",
                            UniverstyGraduatedFrom = "Dokuz Eylül Üniversitesi"
                        });
                });

            modelBuilder.Entity("OzelDers.Entity.Concrete.StudentAndTeacher", b =>
                {
                    b.HasOne("OzelDers.Entity.Concrete.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OzelDers.Entity.Concrete.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("OzelDers.Entity.Concrete.Teacher", b =>
                {
                    b.HasOne("OzelDers.Entity.Concrete.Branch", "Branch")
                        .WithMany()
                        .HasForeignKey("BranchId");

                    b.Navigation("Branch");
                });
#pragma warning restore 612, 618
        }
    }
}
