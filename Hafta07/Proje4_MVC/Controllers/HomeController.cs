using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Proje4_MVC.Controllers;
public class Product
{
    public int Id { get; set; } 
    public string Name { get; set; }    
    public decimal Price { get; set; }  
}
public class Category
{
    public int Id { get; set; } 
    public string Name { get; set; } 
}
public class HomeController : Controller
{
    public IActionResult Index()
    {
        string ad="Zeynep";
        ViewBag.KisiAd=ad;
        string dil="Tr";
        string selamlama;
        if (dil=="Tr")
        {
            selamlama="Hoşgeldiniz";
        }else if(dil=="en")
        {
            selamlama="Welcome";
        }else{
            selamlama="";
        }
        ViewBag.Selam=selamlama;
        return View();
    }
    public IActionResult About()
     {
        ViewBag.Hata=false;
        ViewData["Not"]=75;  // burası viewbage benzer viewdata vewbag gibi controlleden view'e bilgi yollar. not=selam gibi düşün. farkı vd objectlerde kullanılır list yaptığımızda tipi de tanımlamamız lazım about sayfasına bakmalısın.

        List<string> adlar =new List<string>(){"Sema", "Harun","Sefa","Tuğçe"};
        ViewData["Adlar"]=adlar;

        List<string> bolumler =new List<string>(){"Matematik", "Fizik", "İngilizce","Biyoloji"};
        ViewBag.Bolumler=bolumler;
        return View();
     }

    public IActionResult GetProducts()
    {
        List<Product> products =new List<Product>(){
            new Product(){Id=1, Name="Iphone 13", Price=24000},
            new Product(){Id=2, Name="Iphone 14", Price=34000},
            new Product(){Id=3, Name="Iphone 15", Price=44000},
            new Product(){Id=4, Name="Iphone 16", Price=54000},
            new Product(){Id=5, Name="Iphone 17", Price=64000},
        };
       // ViewBag.Products =products;
        
        return View(products);
    }

    public IActionResult Categories()
    {
        List<Category> categories =new List<Category>(){
            new Category(){Id=1, Name="Bilgisayar"},
            new Category(){Id=2, Name="Telefon"},
            new Category(){Id=3, Name="Elektronik"},
        };
        return View(categories);
    }
    
}

//İLK OLARAK BURADA BİR CATEGORİES METODU OLUŞTURDUM. VE BU METODUN VİEWİNİ OLUŞTURDUM VE NAVBAR DA LİNKİ TANIMLADIM DAHA SONRA VİEW DE MODEL TANIMLADIM VE FOREACH İLE BUNU ÇAĞIRDIM EN SON HOME CONTRLLERDE RETURN VİEWLE WEB SAYFAMI HTML OLARAK DÖNDÜRDÜM.

