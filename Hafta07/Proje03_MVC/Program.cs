var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


//MODEL VİEW CONTROLLER
//- CONTROLLER VERİLERİ KONTROL EDER, İŞLER VE MODEL veri tabanına GÖDERİRİR. MODEL VERİYİ TEKRAR CONTROLLE GÖNDERİR. VE CONTROL DE VİEW'E YOLLYARAK GÖRÜNTÜLEMEYİ SAĞLAR.//