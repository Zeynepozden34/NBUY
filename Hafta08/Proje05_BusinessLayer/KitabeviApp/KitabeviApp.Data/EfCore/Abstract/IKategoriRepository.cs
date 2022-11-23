using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Entity;

namespace KitabeviApp.Data.EfCore.Abstract
{
    public interface IKategoriRepository
    {
        List<Kategori> KategoriListele();

        void KategoriEkle(Kategori kategori); //geri döndüreülemeen için void kullanduk.

        void KategoriGuncelle(Kategori kategori);

       public Kategori KategoriGetir(int id);

        void KategoriSil(Kategori kategori);

        public Kategori KategoriSil(int id);

    }
}