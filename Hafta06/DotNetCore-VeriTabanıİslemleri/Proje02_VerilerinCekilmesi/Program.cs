﻿
using System.Data.SqlClient;

namespace Proje02_VerilerinCekilmesi;

class program
{
    static void Main(string[] args)
    {
        getSqlConnection();

    }
    static void getSqlConnection()
    {
        string connectionString = @"Server=DESKTOP-OFVK2FD\SQLEXPRESS;Database=Northwind; User Id=sa; password=123";
        using (var connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
                Console.WriteLine("Bağlantı Sağlandı...");
                string queryString = "SELECT * FROM Products";
                SqlCommand sqlCommand = new SqlCommand(queryString, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                int sayac = 1;
                while (sqlDataReader.Read())
                {
                    Console.WriteLine($"Sıra: {sayac} Name: {sqlDataReader[1]}- Price: {sqlDataReader[5]}");
                    sayac++;
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
    }
}







