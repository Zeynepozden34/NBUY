using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Entity;

namespace KitabeviApp.Business.Abstract
{
    public interface IKategoriService
    {
          List<Kategori> KategoriListele();

        void KategoriEkle(Kategori kategori); 

        void KategoriGuncelle(Kategori kategori);

       public Kategori KategoriGetir(int id);

        void KategoriSil(Kategori kategori);

        public Kategori KategoriSil(int id);

    }
}

 // web katmanından gelen istekler burada karşılanacak