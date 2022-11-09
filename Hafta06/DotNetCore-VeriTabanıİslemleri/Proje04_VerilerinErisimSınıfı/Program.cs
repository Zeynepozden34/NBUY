
using System.Data.SqlClient;

namespace Proje04_VerilerinErisimSınıfı;

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
                customerList();

            }
            else if (secim != 0)
            {
                System.Console.WriteLine("Lütfen geçerli bir secim yapınız");
            }
            Console.ReadLine();
        } while (secim != 0);

        static void customerList()
        {
            List<Customer> customers = GetAllCustomers();
            foreach (var customer in customers)
            {
                System.Console.WriteLine($"ID: {customer.Id}, Company Name: {customer.CompanyName}, city: {customer.City}, Country: {customer.Country} ");
            }
        }
        static void productList()
        {
            List<Product> products = GetAllProducts();
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Stok: {product.Stock}");
            }

        }

    }

    
    static List<Customer> GetAllCustomers() 
    {
        List<Customer> customers = new List<Customer>(); 
        using (var connection = GetSqlConnection())
        {
            try
            {
                connection.Open();
                string queryString = "SELECT CustomerId, CompanyName, City, Country FROM Customers";
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    customers.Add(new Customer()
                    {
                        Id = sqlDataReader["CustomerId"].ToString(), 
                        CompanyName = sqlDataReader["CompanyName"].ToString(),
                        City = sqlDataReader["City"].ToString(),
                        Country = sqlDataReader["Country"].ToString()

                    });
                }
                sqlDataReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                connection.Close();
            }
        }
        return customers;
    }
    
    static List<Product> GetAllProducts() 
    {
        List<Product> products = new List<Product>(); 
        using (var connection = GetSqlConnection())
        {
            try
            {
                connection.Open();
                string queryString = "SELECT ProductId, ProductName, UnitPrice, UnitsInStock FROM Products";
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    products.Add(new Product()
                    {
                        Id = int.Parse(sqlDataReader[0].ToString()), 
                        Name = sqlDataReader[1].ToString(),
                        Price = decimal.Parse(sqlDataReader[2].ToString()),
                        Stock = int.Parse(sqlDataReader[3].ToString())
                    });
                }
                sqlDataReader.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                connection.Close();
            }
        }
        return products;
    }

    static SqlConnection GetSqlConnection()
    {
        string connectionString = @"Server=DESKTOP-OFVK2FD\SQLEXPRESS;Database=Northwind; User Id=sa; password=123";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        return sqlConnection;

    }


}







