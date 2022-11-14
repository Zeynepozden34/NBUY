
using System.Data.SqlClient;
namespace programHazırlık;


class Program
{
    static void Main(string[] args)
    {
       ProductList();
    }
    static void ProductList()
    {
        var sqlProductDAL = new SqlProductDAL();
        List<Product> products = sqlProductDAL.GetAll();
        // var sqliteProductDAL = new SqliteProductDAL();
        // List<Product> products = sqliteProductDAL.GetAllProducts();
        foreach (var product in products)
        {
            Console.WriteLine($"Id: {product.Id}, Name: {product.ProductName}, Price: {product.ProductPrice}, Stock: {product.Stock}");
        }
    }

}
