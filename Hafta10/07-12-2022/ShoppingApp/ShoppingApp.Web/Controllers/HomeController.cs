using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Web.Models.Dtos;

namespace ShoppingApp.Web.Controllers;

public class HomeController : Controller
{
    private readonly IProductService _productManager;

    public HomeController(IProductService productManager)
    {
       _productManager = productManager;
    }

    public async Task<IActionResult> Index()
    {
        var products =await _productManager.GetAllAsync();
        List<ProductDto> productDtos = new List<ProductDto>();
        foreach (var product in products)
        {
            productDtos.Add(new ProductDto
            {
                Id = 1,
                Name = product.Name,
                Price = product.Price,
                DateAdded = product.DateAdded
            });
        }
        return View(products);
    }
}
