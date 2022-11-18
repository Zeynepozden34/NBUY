using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Proje07_ModelBinding_Form.Models;

namespace Proje07_ModelBinding_Form.Controllers;

public class HomeController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }
    //[HttpGet]
    public IActionResult YasGrubu()
    {
        return View();
    }

   [HttpPost] // post metodu olduğunu belirttik.
    public IActionResult YasGrubu(int yas, string ad) // bu post metodu için yeni view açmana gerek yok
    {
       
        if (yas==0)
        {
            ViewBag.YasGrubu="Yaş bilginizi giriniz";
        }
        else if (yas<18)
        {
            ViewBag.YasGrubu=$"{ad}, Reşit değilsiniz.";
        }else if(yas<40)
        {
            ViewBag.YasGrubu=$"{ad},Gençsiniz.";
        }else if(yas<60)
        {
            ViewBag.YasGrubu=$"{ad},Gençlere taş çıkartırısnız.";
        }else{
            ViewBag.YasGrubu=$"{ad},Hala emekli olmadınız mı?";
        }
        return View();
    }

    
    public IActionResult CreateProduct()
    {
        return View();
    }
     [HttpPost]
    public IActionResult CreateProduct(Product product) //string productName, string productCategory, decimal productPrice sildik çünkü product moeli oluşturduk.
    {
        //Burada veri tabanına kayıt işlemi vb. yapılacak.
        //Şimdi verileri testini yapabilmek için tekrar sayfaya bastıralım. ProducCreate Viewinde gönderip web sayfasında görüntüledik.
        // ViewBag.ResultHeader=$"{productName} adlı ürün eklendi.";
        // ViewBag.ResultBody=$"Category: {productCategory}, Price: {productPrice}"; elimde product modeli olduğu için view'e product yazabiliriz.
        
        return View(product);
    }



// Yukardakilerin tipi belirtilmediği için hepsi get metodudur. get metodu sunucudan veri çeker tipii belirtmek için [----]] bu şeilde kullanılır yukarıda yas grubu int yasın üstüne bak. mtodu post yapıldı.

    
    // public IActionResult VerileriAl(string TxtAd, int TxtYas) // Home indexte comment yapıldı.
    // {
    //     return View();
    // }

}
