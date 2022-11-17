using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace Proje06_MVC_KitapEviDb.Controllers;

public class HomeController : Controller
{
    

    public IActionResult Index()
    {
        return View();
    }

    
}
