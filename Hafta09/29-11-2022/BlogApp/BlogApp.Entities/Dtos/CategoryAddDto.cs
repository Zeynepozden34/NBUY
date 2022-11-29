
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Dtos
{
    public class CategoryAddDto
    {
        [DisplayName("İsim")]
        [Required(ErrorMessage = "{0} alanı boş bırakmayınız.")]
        [MaxLength(70, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]
        public string Name { get; set; }


        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş bırakmayınız.")]
        [MaxLength(50, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]
        public string Description { get; set; }


        [DisplayName("Aktif mi?")]
        [Required(ErrorMessage = "{0} alanı boş bırakmayınız.")]
        public bool IsActive { get; set; }



        [DisplayName("Kategori Özel Not")]
        [Required(ErrorMessage = "{0} alanı boş bırakmayınız.")]
        [MaxLength(500, ErrorMessage = "{0} alanının uzunluğu {1} karakteri geçmemelidir.")]
        public string Note { get; set; }

    }
}
