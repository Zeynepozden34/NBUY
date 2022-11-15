using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Proje4_MVC.Controllers;

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

}
