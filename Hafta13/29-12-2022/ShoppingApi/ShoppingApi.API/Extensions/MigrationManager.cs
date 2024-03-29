﻿using Microsoft.EntityFrameworkCore;
using ShoppingApi.Data.Concrete.EfCore.Contexts;

namespace ShoppingApi.API.Extensions
{
    public static class MigrationManager
    {
        public static IHost UpdateDatabase(this IHost host) 
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var shopAppContext = scope.ServiceProvider.GetRequiredService<ShopAppContext>())
                {
                    try
                    {
                        shopAppContext.Database.Migrate();//Bu komut, henüz işlenmemiş migrationları alır ve database update işlemine tabi tutar.
                    }
                    catch (Exception)
                    {
                        //Hataların tututluğu loglar burada hazırlanabilir.
                        throw;
                    }
                }
            }
            return host;
        }
    }
}
