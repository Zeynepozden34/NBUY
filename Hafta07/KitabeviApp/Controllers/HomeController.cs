using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using KitabeviApp.Models;
using Microsoft.EntityFrameworkCore;

namespace KitabeviApp.Controllers;

public class HomeController : Controller
{
    KitabeviContext context = new KitabeviContext();
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult KategoriListesi()
    {
        var kategoriler = context.Kategoriler.ToList();
        return View(kategoriler);
    }
    public IActionResult YazarListesi()
    {
        var yazarlar = context.Yazarlar.ToList();
        return View(yazarlar);
    }
    public IActionResult KitapListesi(int? id=null)  // soru işareti kullanma nedenim id primary key olduğu için null bırakılamaz bu nedenle soru işareti koyduk.
    {
        List<Kitap> kitaplar=null;
        if (id==null)
        {
            
            kitaplar = context
            .Kitaplar
            .Include(k => k.Kategori)
            .Include(k => k.Yazar)
            .ToList();
        }else
        {
        //AsQueryable to liste çevirmeden yapılması gereken birşey varsakullanılır sorgulama yapar.
             kitaplar = context
            .Kitaplar
            .Where(K=>K.KategoriId==id)
            .Include(k => k.Kategori)
            .Include(k => k.Yazar)
            .ToList();
        
        }
        
         return View(kitaplar); 
    }
    public IActionResult Detay(int id)
    {
        var kitap=context.Kitaplar
        .Where(k=>k.Id==id)
        .Include(k=>k.Yazar)
        .Include(k=>k.Kategori)
        .FirstOrDefault();


        return View(kitap);
    }

}
