using BlogApp.Data.Abstract;
using BlogApp.Data.Concrete;
using BlogApp.Data.Concrete.EntityFramework.Contexts;
using BlogApp.Services.Abstract;
using BlogApp.Services.Concrete;
using BlogApp.Services.Extensions;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

#region ServicelerBurayaYazýlýrsa
//builder.Services.AddDbContext<BlogAppContext>(); // uygulamada hiç new context kullanmadýk. program çalýþnca buradan çaðýracaz.
//builder.Services.AddScoped<IUnitOfWork, UnitOfWork>(); // INTERFACEDEN YENÝ NESNE ÜRETÝLEMEZ BURADA BÝZ ÝSTÝSNA YAPIP BUNU BU ÞEKÝLDE KULLANMAK ÝÇÝN AddScoped metodu ile yaptýk.SERVÝCE-CONCRETE-MANAGERLARA BAK
//builder.Services.AddScoped<IArticleService, ArticleManager>();
//builder.Services.AddScoped<ICategoryService, CategoryManager>();
#endregion

#region ServiceExtensionÝleÇaðýrýlýrsa

    builder.Services.LoadByServices();


#endregion


var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
else // hata verirsen uyarýyý göster
{
    app.UseDeveloperExceptionPage();
    app.UseStatusCodePages();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // www.root da kullanýyoruz.

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
