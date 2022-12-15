using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShoppingApp.Business.Abstract;
using ShoppingApp.Business.Concrete;
using ShoppingApp.Data.Abstract;
using ShoppingApp.Data.Concrete;
using ShoppingApp.Data.Concrete.EfCore.Contexts;
using ShoppingApp.Entity.Concrete.Identity;
using ShoppingApp.Web.EmailServices.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<IdentityContext>(options=>options.UseSqlite("Data Source=ShoppingApp.db")); 
builder.Services.AddDbContext<ShopAppContext>();

builder.Services.AddIdentity<User, IdentityRole>()
    .AddEntityFrameworkStores<IdentityContext>()
    .AddDefaultTokenProviders();

builder.Services.Configure<IdentityOptions>(options =>
{
    // �dentity paketi ile ilgili yaplacaklar.
    
    #region PasswordSettings
    options.Password.RequireDigit = true; //�ifre i�inde rakam bulunsun.
    options.Password.RequireLowercase = true; //�ifre i�inde k���kharf bulunsun.
    options.Password.RequireUppercase = true; //�ifre i�inde kb�y�kharf bulunsun.
    options.Password.RequiredLength = 6; //�ifre en az   karakterbulunsun.
    options.Password.RequireNonAlphanumeric = true; //�ifre i�inde en az bir alfan�merik karakter(.,/& gibi) bulunmas� zorunlu olsun.

    #endregion
    #region LoginSettings
    options.Lockout.MaxFailedAccessAttempts = 3;//kullan�c� en fazla 5 kez hatal� girerse hesab� kilitleme ko�ulu
    options.Lockout.DefaultLockoutTimeSpan= TimeSpan.FromSeconds(15); //Kilitlenm� hesaplar i�in 5 dk sonra tekrar deneyebilir.
    #endregion
    #region UserSettings
    options.User.RequireUniqueEmail = true; //Benzersiz e-mail adresi ile kay�t olunabilir.
    #endregion
    #region SignInSettings
    options.SignIn.RequireConfirmedEmail = false; //true ise email onay� aktifdir.
    options.SignIn.RequireConfirmedPhoneNumber = false; // trueise telefo numaras� onay� aktiftir.
    #endregion

});

builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/account/login"; //E�er a��labilmesi login olduman�n zorunlu oldu�u bir istekte bulunursa kullan�c�n y�nlendirilece�i sayfa buras� olacak (account controll�ndeki login action metodu.)
    options.LogoutPath= "/account/logout"; // kullan�c� ��k�� yapt���nda y�nlendirilecek sayfa.
    options.AccessDeniedPath= "/account/accessdenied"; //Yetkisiz giri� s�ras�nda y�nlendrilecek sayfa
    options.SlidingExpiration = true; // cokkie yarat�ld���nda ya�am s�resi 20 dk'd�r e�er bu true ise her yeni istekte ya�am s�resi yeniden ba�lar.
    options.ExpireTimeSpan= TimeSpan.FromMinutes(15); //ya�am s�resini ayarlar   
    options.Cookie = new CookieBuilder
    {
        HttpOnly = true, //http ile gelen istekleri kar��layacak.
        Name = ".ShoppingApp.Security.Cookie",
        SameSite =SameSiteMode.Strict

    };
});

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IEmailSender, SmtpEmailSender>(x=>new SmtpEmailSender(
        "smtp.office365.com", 587, true, "wissen_core@hotmail.com", "Wissen123."
    ));

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "products",
    pattern: "kategori/{categoryurl?}",
    defaults: new { controller = "Shop", action = "ProductList" }
    );

app.MapControllerRoute(
    name:"productdetails",
    pattern:"urunler/{producturl}",
    defaults: new {controller="Shop", action="ProductDetails"}
    );


app.MapAreaControllerRoute(
    name: "Admin",
    areaName: "Admin",
    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"); ;

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
