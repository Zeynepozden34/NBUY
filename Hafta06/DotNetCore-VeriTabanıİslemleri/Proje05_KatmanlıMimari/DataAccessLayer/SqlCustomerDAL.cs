using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Proje05_KatmanlıMimari.DataAccessLayer.Entities;


namespace Proje05_KatmanlıMimari.DataAccessLayer
{
    private static SqlConnection GetSqlConnection()
    {
        string connectionString = @"Server=DESKTOP-OFVK2FD\SQLEXPRESS;Database=Northwind; User Id=sa; password=123";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        return sqlConnection;

    }

    public class SqlCustomerDAL : ICustomerDAL
    {
        public void CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
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

        public Customer getById(string id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}