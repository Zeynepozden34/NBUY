using ShoppingApp.Entity.Concrete;

namespace ShoppingApp.Web.Areas.Admin.Models.Dtos
{
    public class ProductListDto
    {
        // Liste halinde getirmeme nedeni kolaylık olsun diye product'ın hepsini getirdik.
        public Product Product { get; set; }
    }
}
