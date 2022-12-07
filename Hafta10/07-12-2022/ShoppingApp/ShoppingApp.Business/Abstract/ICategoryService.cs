using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Business.Abstract
{
    public interface ICategoryService
    {
        // generic ve repositoryde tüm metotlar burada olmalı. data-concrete-repository ve data-abstractaki repository
        Task<Category> GetByIdAsync(int id);
        Task<List<Category>> GetAllAsync();
        Task CreateAsync(Category category);
        void Update(Category category);
        void Delete(Category category);
        Category GetByIdWithProducts(int id);
    }
}
