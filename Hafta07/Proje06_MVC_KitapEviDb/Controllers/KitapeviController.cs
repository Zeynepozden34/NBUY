using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proje06_MVC_KitapEviDb.Models;
using Microsoft.EntityFrameworkCore;

namespace Proje06_MVC_KitapEviDb.Controllers
{
    
    public class KitapeviController : Controller
    {
        
        public IActionResult Kategori()
        {
            KitapEviDb context = new KitapEviDb();
            var categories =context.Categories.ToList();
            return View(categories);
        }
        public IActionResult Kitap()
        {
            KitapEviDb context = new KitapEviDb();
    
            List<Kitap> kitaplar = context
             .Kitaplar
            .Include(k => k.Kategori)
            .Include(k=>k.Yazar)
            .ToList();
            return View(kitaplar);
        }
        public IActionResult Yazar()
        {
            KitapEviDb context = new KitapEviDb();
            var yazarlar =context.Yazarlar.ToList();
            return View(yazarlar);
        }


       
    }
}