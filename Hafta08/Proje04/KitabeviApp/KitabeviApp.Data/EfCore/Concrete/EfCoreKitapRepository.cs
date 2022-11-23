using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitabeviApp.Data.EfCore.Abstract;
using KitabeviApp.Entity;
using Microsoft.EntityFrameworkCore;

namespace KitabeviApp.Data.EfCore.Concrete
{
    public class EfCoreKitapRepository : IKitapRepository
    {
        public List<Kitap> KitapListele(int? id = null)
        {
            using (var context = new KitabeviContext())
            {
                if (id == null)
                {
                    return context
                        .Kitaplar
                        .Include(k => k.Kategori)
                        .Include(k => k.Yazar)
                        .ToList();
                }
                
                     return context
                        .Kitaplar
                        .Where(c => c.KategoriId == id)
                        .Include(k => k.Kategori)
                        .Include(k => k.Yazar)
                        .ToList();
                // else yazmamamızın sebebi id null ise return yapavak null değilse yine return yapavak.

            }
        }
    }
}