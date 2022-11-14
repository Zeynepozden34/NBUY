using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace programHazırlık
{
    public interface IProductDAL
    {
         void Create (Product product);
         List<Product> GetAll();
         Product GetById(int id);
         void Update(Product product);
         void Delete(int id);
    }
    public class SqlProductDAL : IProductDAL
    {
          static SqlConnection GetSqlConnection()
        {
            string connectionString = @"Server=NIRVANAZEYNEP\SQLEXPRESS;Database=Northwind; User Id=sa; password=123";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            return sqlConnection;

        }
        public void Create(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            List<Product> products =new List<Product>();
            using (var connection =GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    string queryString="SELECT ProductId, ProductName, UnitPrice, UnitsInStock FROM Products";
                    SqlCommand sqlCommand =new SqlCommand(queryString,connection);
                    SqlDataReader sqlDataReader= sqlCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        products.Add(new Product()
                        {
                            Id=int.Parse(sqlDataReader["ProductId"].ToString()),
                           ProductName=sqlDataReader["ProductBame"].ToString(),
                           ProductPrice=decimal.Parse(sqlDataReader["ProductPrice"].ToString()),
                           Stock=int.Parse(sqlDataReader["ProductInStock"].ToString())
                        });
                        sqlDataReader.Close();
                    }



                }
                catch (System.Exception)
                {
                    
                    
                }
            }
            return products;
        }


        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}