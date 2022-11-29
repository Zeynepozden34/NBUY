using BlogApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dto= Data Transfer Object = veri taşımak için nesne yaratmaya yarayan tipler. NOrmalde birçok bilgi isten,yor mesela görüntülenme sayısı gibi kullanıcı bunları girmeyecek kulanıcın gireceği şeyleri burada gösterdik. Article ekleren kullanılacak model budur. 
namespace BlogApp.Entities.Dtos 
{
    public class ArticleAddDto
    {
        // Kodlarımız ingilizce ama görüntülenince türkçe olmasını istiyoruz bunu aşağıdaki gibi yaparız. Articlemap'e bakarak ilereldik.

        [DisplayName("Başlık")] // Aşağıdaki {0} Başlık kısmını kastediyor displayNamenin içindekini kastediyoruz {1} bu da maxlength yada mn length indeksi bu şekilde devamedecek
        [Required(ErrorMessage ="{0} alanı boş geçilmemelidir.")]
        [MaxLength(100, ErrorMessage ="{0} alanının uzunluğu {1} karakteri geçmemelidir.")]
        [MinLength(5, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]
        public string Title { get; set; }


        [DisplayName("İçerik")] 
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MinLength(5, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]
        public string Content { get; set; }


        [DisplayName("Thumbnail")] 
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(250, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]
        [MinLength(5, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]
        public string Thumbnail { get; set; }


        [DisplayName("Tarih")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }


        [DisplayName("Seo Yazar")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(50, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]
        public string SeoAuthor { get; set; }


        [DisplayName("Seo Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(150, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]
        public string SeoDescription { get; set; }


        [DisplayName("Seo Etiketleri")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [MaxLength(70, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]
        public string SeoTags { get; set; }


        [DisplayName("Kategori")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public int CategoryId { get; set; } //Viewde Id göstermeyecez bu yüzden displaya kategori diyebilriz.
        public Category Category { get; set; } //Navigation property Viewde göstermeyecez


        [DisplayName("Aktif mi?")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public bool IsActive { get; set; }
    }
}
