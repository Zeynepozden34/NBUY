using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KitabeviApp.Web.ViewModels
{
    public class YazarViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Lütfen adı boş bırakmayınız.")]
        [StringLength(30,ErrorMessage ="Lütfen 30 karakterden fazla girmeyiniz!!")]
        [Display(Name ="Yazar Adı Soyadı:", Prompt ="Lütfen yazar ad soyadını giriniz...")]
        public string Ad { get; set; }
        [Required(ErrorMessage ="Lütfen doğum yılını boş bırakmayınız.")]
        [Display(Name ="Yazar Doğum Yılı:", Prompt ="2000...")]
        public int? DogumYili { get; set; }  
        public char Cinsiyet { get; set; }
    }
}