using BlogApp.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Entities.Concrete
{
    public class Category :EntityBase,IEntity
    {
        public string  Name { get; set; }
        public string Description { get; set; }
        public ICollection<Article> Articles { get; set; }  //Navigation property
        // kategori ve artikler arasında bire çok ilişli var o yüzden ICollection yaptık, list de kullanbilirdik ama proje büyük oludğu için bunu kullandık. bir kategoride biren fazla article kullanabiliriz

    }
}




//----------------------------ARAŞTIRMA------------------------------
//List, ArrayList.Array.Ilist.ICollection yaplarını miras alma özellikeri açısından inceleyiniz.(Microsoft dökümantasyonu)