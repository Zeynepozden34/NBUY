using System.Data.SqlClient;
using Proje05_KatmanlıMimari.DataAccessLayer.Entities;
namespace Proje05_KatmanlıMimari.DataAccessLayer
{
    public class SqlProductDAL : IProductDAL
    {
        static SqlConnection GetSqlConnection()
        {
            string connectionString = @"Server=DESKTOP-OFVK2FD\SQLEXPRESS;Database=Northwind; User Id=sa; password=123";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;

        }

        public void CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProducts()
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

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategory(string categoryName)
        {
            throw new NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }

}