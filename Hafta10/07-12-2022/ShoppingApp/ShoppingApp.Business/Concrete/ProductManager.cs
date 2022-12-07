﻿using ShoppingApp.Business.Abstract;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductManager(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        #region Generics
        public async Task<Product> GetByIdAsync(int id)
        {
            return await _unitOfWork.Products.GetByIdAsync(id);
        }
        public async Task<List<Product>> GetAllAsync()
        {
            return await _unitOfWork.Products.GetAllAsync();
        }

        public async Task CreateAsync(Product product)
        {
            await _unitOfWork.Products.CreateAsync(product);
            await _unitOfWork.SaveAsync();
        }
        public void Update(Product product)
        {
            _unitOfWork.Products.Update(product);
            _unitOfWork.Save();
        }
        public void Delete(Product product)
        {
            _unitOfWork.Products.Delete(product);
            _unitOfWork.Save();
        }
        public Product GetByIdWithProducts(int id)
        {
            throw new NotImplementedException();
        }


        #endregion

        #region Products
        public List<Product> GetProductsByCategory()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetHomePageProducts()
        {
            throw new NotImplementedException();
        }


        #endregion




    }
}
