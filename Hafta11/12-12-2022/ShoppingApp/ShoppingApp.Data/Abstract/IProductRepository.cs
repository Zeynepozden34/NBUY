﻿using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
     
        Task<List<Product>> GetProductsByCategoryAsync(string category);
        Task<List<Product>> GetHomePageProductsAsync();
        Task<Product> GetProductDetailsByUrlAsync(string productUrl);
        Task<List<Product>> GetProductsWithCategories();
        Task CreateProductAsync(Product product, int[] selectedCategoryIds);
        Task UpdateProductAsync(Product product, int[] selectedCategoryIds);
        Task<Product> GetProductWithCategories(int id);

    }
}
