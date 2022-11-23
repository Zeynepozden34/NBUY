using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Entity;

namespace KitabeviApp.Data.EfCore.Abstract
{
    public interface IYazarRepository
    {
        List<Yazar> YazarListele();
        
        void YazarEkle(Yazar yazar);
        
        public Yazar YazarGetir(int id);

        void YazarGuncelle(Yazar yazar);

        public Yazar YazarSil(int id);

        void YazarSil(Yazar yazar);
       
        
    }
}