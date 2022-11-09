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
            1.Adım: connection string oluşturmak. veri tabanına bağlanmamızı sağlayan string ifadedeir. hangi servere bağlandığımızı buraya yazacaz.
        */
        string connectionString = @"Server=DESKTOP-OFVK2FD\SQLEXPRESS;Database=Northwind; User Id=sa; password=123";
        // var Connection = new SqlConnection(connectionString);
        // Connection.Open();
        //sqlConnection bir pakettir system.data.sqlcliente bulunan bir nesne tipini connectStringe ekledik. 
        using (var Connection = new SqlConnection(connectionString))
        {
            // connection şu an nortwind veri tabanını çalıştıran nesne
            //connection nesne sadece bu scope içinde yaşar ve scope bitişinde bellekten kaldırılmış olur. 
           try
           {
            Connection.Open();
             Console.WriteLine("Bağlantı Sağlandı...");
           }
           catch (Exception e)
           {
             Console.WriteLine(e.Message);
           
           }
           finally
           {
                Connection.Close();
           }
        }
        
    }
}
