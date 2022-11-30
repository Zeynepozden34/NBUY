using BlogApp.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlogApp.Mvc.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")] // admine ait olduğunu gösteriyoruz 
        public IActionResult Index()
        {
            return View();
        }

        
    }
}