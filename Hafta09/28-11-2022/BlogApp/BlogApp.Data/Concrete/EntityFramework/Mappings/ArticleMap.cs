using BlogApp.Entities.Concrete;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Data.Concrete.EntityFramework.Mappings
{
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            #region Acıklama
            // Burada EFCORE TARAFINDAN DEFAULT VONVENTİON YÖNTEMİYLE KENDLİĞİNDEN GERÇEKLEŞEN BAZI AYARLARI ELLE YAPACAZ. BU DAHA SÜRDÜRÜLEBİLİR GENİŞLETİLEBİLİR UYGULAMALAR YAPMAK İÇİN TERCİH EDİLEN BİR YOLDUR. 
            #endregion
            builder.HasKey(a=>a.Id); // PrimaryKey bu şekilde yapılır.
            builder.Property(a => a.Id).ValueGeneratedOnAdd(); // (Identity)Id'nin otoatik olarak eklendikçe birer birer artırmamızı sağlar
            builder.Property(a => a.Title).IsRequired(true); // IsRequired(true) girilmesi zoruludur. zorunlu varsayılanı truedır.
            builder.Property(a=>a.Title).HasMaxLength(100); // Maximum 100 Karakter girilmesi gerekiyor.

            builder.Property(a => a.Content).IsRequired();
            builder.Property(a=>a.Content).HasColumnType("NVARCHAR(MAX)"); // tipini değiştirmek için bunu kullanırız.

            builder.Property(a => a.Thumbnail).IsRequired();
            builder.Property(a => a.Thumbnail).HasMaxLength(250);

            builder.Property(a=>a.Date).IsRequired();
            
            builder.Property(a=>a.SeoAuthor).IsRequired();
            builder.Property(a=>a.SeoAuthor).HasMaxLength(50);

            builder.Property(a => a.SeoDescription).IsRequired();
            builder.Property(a => a.SeoDescription).HasMaxLength(150);

            builder.Property(a => a.SeoTags).IsRequired();
            builder.Property(a => a.SeoTags).HasMaxLength(70);

            builder.Property(a => a.ViewsCount).IsRequired();

            builder.Property(a => a.CommentCount).IsRequired();

            builder.Property(a => a.CreatedByName).IsRequired();
            builder.Property(a => a.CreatedByName).HasMaxLength(250);

            builder.Property(a => a.CreatedDate).IsRequired();

            builder.Property(a => a.ModifiedDate).IsRequired();

            builder.Property(a => a.IsDeleted).IsRequired();

            builder.Property(a => a.IsActive).IsRequired();

            builder.Property(a => a.Note).HasMaxLength(500);

            //Categori=1 article=çok, bire çok ilişkiyi şu şekilde tanımlarız, .HasOne(c => c.Category) ilişkinin tek olan tarafı,  .WithMany(a => a.Articles) articlenin çok olan taraf olduğunu, HasForeignKey(a=>a.CategoryId) forinkeyni bu şekilde tanımlarız.
            builder.HasOne(a => a.Category).WithMany(a => a.Articles).HasForeignKey(a=>a.CategoryId);

            builder.HasOne(a => a.User).WithMany(a => a.Articles).HasForeignKey(a => a.UserId);


            //VeriTabanında ARTİCLE yERİNE başka birşey yazamak İÇİN kullanılır.
            builder.ToTable("Articles");


            //İLk ARticle verilerini eklenmesi
            builder.HasData(
                new Article
                {
                    Id = 1,
                    CategoryId= 1,
                    UserId= 1,
                    Title="C# 11.0 Yenilikleri",
                    Content= "Lorem Ipsum, dizgi ve baskı endüstrisinde kullanılan mıgır metinlerdir. Lorem Ipsum, adı bilinmeyen bir matbaacının bir hurufat numune kitabı oluşturmak üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'larda Lorem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.",
                    Thumbnail="default.jpg",
                    SeoDescription= "C# 11.0 Yenilikleri",
                    SeoTags= "c#, C# 11.0, Dotnet 6, Dotnet-7, Dotnet Core",
                    SeoAuthor="Deniz Gezen",
                    ViewsCount= 1,
                    Date= DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreated",
                    ModifiedDate = DateTime.Now,
                    Note = "C# 11.0 Yenilikleri."
                },
                new Article
                {
                    Id = 2,
                    CategoryId = 2,
                    UserId = 1,
                    Title = "Modern Javascript",
                    Content = "Yinelenen bir sayfa içeriğinin okuyucunun dikkatini dağıttığı bilinen bir gerçektir. Lorem Ipsum kullanmanın amacı, sürekli 'buraya metin gelecek, buraya metin gelecek' yazmaya kıyasla daha dengeli bir harf dağılımı sağlayarak okunurluğu artırmasıdır. Şu anda birçok masaüstü yayıncılık paketi ve web sayfa düzenleyicisi, varsayılan mıgır metinler olarak Lorem Ipsum kullanmaktadır. Ayrıca arama motorlarında 'lorem ipsum' anahtar sözcükleri ile arama yapıldığında henüz tasarım aşamasında olan çok sayıda site listelenir. Yıllar içinde, bazen kazara, bazen bilinçli olarak (örneğin mizah katılarak), çeşitli sürümleri geliştirilmiştir",
                    Thumbnail = "default.jpg",
                    SeoDescription = "Modern Javascript",
                    SeoTags = "ECMA Script 6, map, filter, reduce, arrow function",
                    SeoAuthor = "Deniz Gezen",
                    ViewsCount = 1,
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreated",
                    ModifiedDate = DateTime.Now,
                    Note = "Modern Javascript"
                },
                new Article
                {
                    Id = 3,
                    CategoryId = 3,
                    UserId = 2,
                    Title = "React Component Yapısı",
                    Content = "Lorem Ipsum pasajlarının birçok çeşitlemesi vardır. Ancak bunların büyük bir çoğunluğu mizah katılarak veya rastgele sözcükler eklenerek değiştirilmişlerdir. Eğer bir Lorem Ipsum pasajı kullanacaksanız, metin aralarına utandırıcı sözcükler gizlenmediğinden emin olmanız gerekir. İnternet'teki tüm Lorem Ipsum üreteçleri önceden belirlenmiş metin bloklarını yineler. Bu da, bu üreteci İnternet üzerindeki gerçek Lorem Ipsum üreteci yapar. Bu üreteç, 200'den fazla Latince sözcük ve onlara ait cümle yapılarını içeren bir sözlük kullanır. Bu nedenle, üretilen Lorem Ipsum metinleri yinelemelerden, mizahtan ve karakteristik olmayan sözcüklerden uzaktır.",
                    Thumbnail = "default.jpg",
                    SeoDescription = "React Component Yapısı",
                    SeoTags = "React, React Js, component, state, class component, function component",
                    SeoAuthor = "Yusuf Onan",
                    ViewsCount = 225,
                    Date = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    CreatedByName = "InitialCreate",
                    CreatedDate = DateTime.Now,
                    ModifiedByName = "InitialCreated",
                    ModifiedDate = DateTime.Now,
                    Note = "React Component Yapısı"
                }
                );


        }
    }
}

// Çoka bir tarif ederken hasMany kullanılır