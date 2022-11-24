using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Business.Abstract;
using KitabeviApp.Data.EfCore.Concrete;
using KitabeviApp.Entity;

namespace KitabeviApp.Business.Concrete
{
    public class KategoriManager : IKategoriService
    {
        public void KategoriEkle(Kategori kategori)   //public void de return olmamal� geri d�nd�r�lemez.
        {
            var kategoriRepository = new EfCoreKategoriRepository();
            kategoriRepository.KategoriEkle(kategori);
        }

        public Kategori KategoriGetir(int id)  //public kategori de return olmal�
        {
            var kategoriRepository = new EfCoreKategoriRepository();
            return kategoriRepository.KategoriGetir(id);
        }

        public void KategoriGuncelle(Kategori kategori)
        {
            throw new NotImplementedException();
        }

        public List<Kategori> KategoriListele()
        {
            var kategoriRepository=new EfCoreKategoriRepository();
            return kategoriRepository.KategoriListele();
        }

        public void KategoriSil(Kategori kategori)
        {
            throw new NotImplementedException();
        }

        public Kategori KategoriSil(int id)
        {
            throw new NotImplementedException();
        }
    }
}