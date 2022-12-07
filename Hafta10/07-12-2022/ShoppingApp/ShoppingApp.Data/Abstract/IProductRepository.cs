using ShoppingApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Data.Abstract
{
    public interface IProductRepository  :IRepository<Product> // bir interfaceye interfaceden miras aldırırsak implemente etmemeize gerek kalmaz.
    {
        //Producta özgü memberler burada olacak.(property, field, method....)
        List<Product> GetProductsByCategory();
        List<Product> GetHomePageProducts();
    }
}
