using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Business.Concrete;
using ShoppingApp.Entity.Concrete;
using ShoppingApp.Web.Areas.Admin.Models.Dtos;
using ShoppingApp.Web.Models.Dtos;
using System.Xml.Linq;

namespace ShoppingApp.Web.Controllers
{
    public class ShopController : Controller
    {
        private readonly IProductService _productManager;

        public ShopController(IProductService productManager)
        {
            _productManager = productManager;
        }

        public IActionResult Index()
        {
            return null;
            //var product = await _productManager.GetAllAsync();
            //ProductShoppingAddDto productShoppingAddDto = new ProductShoppingAddDto
            //{
            //    Id = product.Id,
            //    Name = product.Name,
            //    Price = product.Price,
            //    ImageUrl = product.ImageUrl,
            //    Url = product.Url,
            //    Description = product.Description,
            //    Categories = product
            //        .ProductCategories
            //        .Select(pc => pc.Category)
            //        .ToList()

            //};
            //return View(productShoppingAddDto);
        }

        public async Task<IActionResult> ProductList(string categoryurl)
        {
            List<Product> products = await _productManager.GetProductsByCategoryAsync(categoryurl);
            List<ProductDto> productDtos = new List<ProductDto>();
            foreach (var product in products)
            {
                productDtos.Add(new ProductDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    ImageUrl = product.ImageUrl,
                    Url=product.Url,
                });
            }
            return View(productDtos);
        }
        public  async Task<IActionResult> ProductDetails(string producturl)
        {
            if (producturl==null)
            {
                return NotFound();
            }
            var product = await _productManager.GetProductDetailsByUrlAsync(producturl);
            ProductDetailsDto productDetailsDto = new ProductDetailsDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                Url = product.Url,
                Description = product.Description,
                Categories = product
                    .ProductCategories
                    .Select(pc => pc.Category)
                    .ToList()
            };

            return View(productDetailsDto);
        }
        public async Task<IActionResult> ProductShoppingAdd(string producturl) 
        {
            var product = await _productManager.GetProductShoppingAddAsync(producturl);
            ProductShoppingAddDto productShoppingAddDto = new ProductShoppingAddDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                ImageUrl = product.ImageUrl,
                Url = product.Url,
                Description = product.Description,
                Categories = product
                    .ProductCategories
                    .Select(pc => pc.Category)
                    .ToList()

            };
            return View(productShoppingAddDto);
        }
    }
}
