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

//app.MapDefaultControllerRoute();
app.MapControllerRoute(
    //app.MapControllerRoute(); aşagıdaki default'un kısa yoludur.
     name: "default",
     pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
