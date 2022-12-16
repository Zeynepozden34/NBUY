using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ShoppingApp.Web.Areas.Admin.Controllers
{
    [Authorize] // bu kontrolden istekte bulunmak için giriş yapmış olman lazım.
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
