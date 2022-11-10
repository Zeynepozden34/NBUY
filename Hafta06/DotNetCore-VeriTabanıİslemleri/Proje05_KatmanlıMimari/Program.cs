
using System.Data.SqlClient;
using Proje05_KatmanlıMimari.DataAccessLayer;
using Proje05_KatmanlıMimari.BusinessLayer;
using Proje05_KatmanlıMimari.DataAccessLayer.Entities;


namespace Proje05_KatmanlıMimari;

class program
{

    static void Main(string[] args)
    {
        int secim;
        do
        {
            Console.Clear();
            Console.WriteLine("1-Product List");
            Console.WriteLine("2-Cunsomer List");
            Console.WriteLine("0-Exit");
            Console.Write("lütfen seçim yapınız: ");
            secim = int.Parse(Console.ReadLine());
            if (secim == 1)
            {
                productList();
            }
            else if (secim == 2)
            {
                //customerList();
                Console.ReadLine();
            }
            else if (secim != 0)
            {
                System.Console.WriteLine("Lütfen geçerli bir secim yapınız");
            }
            Console.ReadLine();
        } while (secim != 0);

        //static void customerList()
        {
            // List<Customer> customers = GetAllCustomers();
            // foreach (var customer in customers)
            // {
            //     System.Console.WriteLine($"ID: {customer.Id}, Company Name: {customer.CompanyName}, city: {customer.City}, Country: {customer.Country} ");
            // }
        }
        static void productList()
        {
           var productManager =new ProductManager(new SqliteProductDAL());
           List<Product> products = productManager.GetAllProducts();
            
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Stok: {product.Stock}");
            }

        }

    } 
    // static List<Customer> GetAllCustomers() 
    // {
    //     List<Customer> customers = new List<Customer>(); 
    //     using (var connection = GetSqlConnection())
    //     {
    //         try
    //         {
    //             connection.Open();
    //             string queryString = "SELECT CustomerId, CompanyName, City, Country FROM Customers";
    //             SqlCommand sqlCommand = new SqlCommand(queryString, connection);
    //             SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
    //             while (sqlDataReader.Read())
    //             {
    //                 customers.Add(new Customer()
    //                 {
    //                     Id = sqlDataReader["CustomerId"].ToString(), 
    //                     CompanyName = sqlDataReader["CompanyName"].ToString(),
    //                     City = sqlDataReader["City"].ToString(),
    //                     Country = sqlDataReader["Country"].ToString()

    //                 });
    //             }
    //             sqlDataReader.Close();
    //         }
    //         catch (Exception e)
    //         {
    //             Console.WriteLine(e.Message);

    //         }
    //         finally
    //         {
    //             connection.Close();
    //         }
    //     }
    //     return customers;
    // }
    
    

   


}







