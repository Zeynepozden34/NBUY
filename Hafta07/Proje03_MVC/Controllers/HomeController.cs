using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Proje03_MVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();   //içine birşey yazmazsak index adında metotun(contraller içinde yer alan metotlara action metod denir)içinde olan home' da arar ve görüntüler.
    }

    public IActionResult Privacy()
    {
        return View();
    }
    public IActionResult About()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }
   
}
