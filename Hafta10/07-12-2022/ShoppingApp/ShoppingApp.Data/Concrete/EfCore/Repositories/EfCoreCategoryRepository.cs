using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete.EfCore.Contexts;
using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(ShopAppContext context) : base(context)
        {
            //buraya gelen context base classa gönderiliyor ve aynı zamnada sadece bu costructor için geçerli. ama bu classın bütüünde henüz kullanılmıyor. eğer kullanmak istersen yapmamaız gereken işleler var.
        }

        public Category GetByIdWithProducts()
        {
            throw new NotImplementedException();
        }
    }
}
