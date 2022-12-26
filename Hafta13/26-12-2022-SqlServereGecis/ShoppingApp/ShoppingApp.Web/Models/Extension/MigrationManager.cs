using Microsoft.EntityFrameworkCore;
using ShoppingApp.Data.Concrete.EfCore.Contexts;

namespace ShoppingApp.Web.Models.Extension
{
    public static  class MigrationManager 
    {
        public static IHost UpdateDatabase(this IHost host) //sHOPAPP CONTEXT TİPİNDE YENİ BİR SCOP YARATTUIK.
        {
            using (var scope=host.Services.CreateScope()) //builder.services gibi yeni bir scop yarattık.
            {
                using (var shopAppContext =scope.ServiceProvider.GetRequiredService<ShopAppContext>())
                {
                    try
                    {
                        shopAppContext.Database.Migrate();//bu komut henüz işlenmemiş migrationları alır ve database update işlemine tabi tutar
                    }
                    catch (Exception)
                    {
                        //hataların bulunduğu loglar burada hazırlanır.
                        throw;
                    }
                }
            }
            return host;
        }
    }
    
}
