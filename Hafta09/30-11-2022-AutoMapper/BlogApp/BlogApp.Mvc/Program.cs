using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete;
using BlogApp.Data.Concrete.EntityFramework.Contexts;
using BlogApp.Services.Abstract;
using BlogApp.Services.Concrete;
using BlogApp.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

#region ServicelerBurayaYaz�l�rsa
//builder.Services.AddDbContext<BlogAppContext>(); // uygulamada hi� new context kullanmad�k. program �al��nca buradan �a��racaz.
//builder.Services.AddScoped<IUnitOfWork, UnitOfWork>(); // INTERFACEDEN YEN� NESNE �RET�LEMEZ BURADA B�Z �ST�SNA YAPIP BUNU BU �EK�LDE KULLANMAK ���N AddScoped metodu ile yapt�k.SERV�CE-CONCRETE-MANAGERLARA BAK
//builder.Services.AddScoped<IArticleService, ArticleManager>();
//builder.Services.AddScoped<ICategoryService, CategoryManager>();
#endregion

#region ServiceExtension�le�a��r�l�rsa

    builder.Services.LoadByServices();


#endregion


var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
else // hata verirsen uyar�y� g�ster
{
    app.UseDeveloperExceptionPage();
    app.UseStatusCodePages();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // www.root da kullan�yoruz.

app.UseRouting();

app.UseAuthorization();

app.MapAreaControllerRoute(
    name: "Admin",
    areaName:"Admin",
     pattern: "/Admin/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
