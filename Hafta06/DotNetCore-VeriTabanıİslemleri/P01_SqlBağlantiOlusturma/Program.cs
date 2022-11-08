using System.Data.SqlClient;

namespace P01_SqlBağlantiOlusturma;
class Program
{
    static void Main(string[] args)
    {
        GetSqlConnection();
        
    }
    static void GetSqlConnection()
    {
        /* 
            1.Adım: connection string oluşturmak.
        */
        string connectionString = @"Server=DESKTOP-OFVK2FD\SQLEXPRESS;Database=Northwind; User Id=sa; password=123";
        // var Connection = new SqlConnection(connectionString);
        // Connection.Open();
        using (var Connection = new SqlConnection(connectionString))
        {
            //connection nesne sadece bu scope içinde yaşar ve scope bitişinde bellekten kaldırılmış olur.
           try
           {
            Connection.Open();
             Console.WriteLine("Bağlantı Sağlandı...");
           }
           catch (Exception e)
           {
             Console.WriteLine(e.Message);
            throw;
           }
           finally
           {
                Connection.Close();
           }
        }
        
    }
}
