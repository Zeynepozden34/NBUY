using Microsoft.AspNetCore.Mvc;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Business.Concrete;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete;
using ShoppingApp.Data.Concrete.EfCore.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ShopAppContext>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//app.MapControllerRoute( // shared/productpartial bak
//    name:"productDetails",
//    pattern:"{url?}",
//    defaults:new {controller="Shop", action="ProductDetails"}    
//    );
//https:/localhost:5178/shop/productdetails/iphone-13-plus


//app.MapControllerRoute( //component/categories/default bak 
//    name: "products", 
//    pattern: "{category?}",  // bu bizim url tasar�m�m�z� sa�lar hangi kategorideysek o yazacak.
//    defaults: new { controller = "Shop", action = "ProductList" }
//    //https:/localhost:5178/elektronik
//    ); silmemizin nedeni a��lan sayfada home ��ks�n ama comment yap�nca url bozulutor b nedenle default dosyas�nda defaults:asp-route-category i id yazd�k ama hala url istedi�imiz gibi olmad� olan://https:/
//    localhost:5178/shop/productdetails/iphone-13-plus olmas� gereekn https:/localhost:5178/elektronik


app.MapControllerRoute(   //component/categories/default bak 
    name: "products",
    pattern: "kategori/{categoryurl?}",
    defaults: new { controller = "Shop", action = "ProductList" }
    );

app.MapControllerRoute(  //shared / productpartial bak
    name:"productdetails",
    pattern:"urunler/{producturl}",
    defaults:new {controller="Shop", action= "ProductDetails" }    
    );

app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );
    //www.enginniyazi.com/home/index
app.Run();
