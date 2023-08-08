using BlogProject.Data.Context;
using BlogProject.Data.Extensions;
using BlogProject.Entity.Entities;
using BlogProject.Services.Describers;
using BlogProject.Services.Extensions;
using Microsoft.AspNetCore.Identity;
using NToastNotify;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.LoadDataLayerExtension(builder.Configuration);
builder.Services.LoadServiceLayerExtensions(); //MyServiceLayerExtensions
builder.Services.AddSession(); //Oturumlar için
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

builder.Services.AddControllersWithViews().AddNToastNotifyToastr(new ToastrOptions() //Toastr Service
{
    ProgressBar = true,
    PositionClass = ToastPositions.TopRight,
    CloseButton = true,
    TimeOut = 5000

}).AddRazorRuntimeCompilation();
//-------------------------------DIKKAT-------------------------------
//CANLI ÖNCESI BURAYI KALDIR
builder.Services.AddIdentity<AppUser, AppRole>(
    opt =>
    {
        opt.Password.RequireNonAlphanumeric = false;
        opt.Password.RequireLowercase = false;
        opt.Password.RequireUppercase = false;
    })
    .AddRoleManager<RoleManager<AppRole>>()
    .AddErrorDescriber<CustomIdentityErrorDescriber>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();
//-------------------------------DIKKAT-------------------------------
//-------------------------------DIKKAT-------------------------------
builder.Services.ConfigureApplicationCookie(config =>
{
    config.LoginPath = new PathString("/Admin/Auth/Login"); //Area/[controller]/[action] => Biri giriþ yapmamýþsa bu sayfaya yönlendirsin diye.
    config.LogoutPath = new PathString("/Admin/Auth/Logout");
    config.Cookie = new CookieBuilder
    {
        Name = "tayfunfirtina",
        HttpOnly = true,
        SameSite = SameSiteMode.Strict,
        SecurePolicy = CookieSecurePolicy.SameAsRequest //CANLIDA BURAYI "always" olarak deðiþtirmeyi unutma
    };
    config.SlidingExpiration = true;
    config.ExpireTimeSpan = TimeSpan.FromDays(7);
    config.AccessDeniedPath = new PathString("/Admin/Auth/AccessDenied"); // => Yetkisiz yapýlmak istenen iþlemlerde bu sayfaya yönlendiricem.
});
//-------------------------------DIKKAT-------------------------------

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseNToastNotify(); //Toastr icin
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession(); //Oturumlar için 

app.UseRouting();
app.UseAuthentication(); //Her zaman UseAuthorizationun üstünde olması lazım.
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

//My Areas EndPoint
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Default}/{action=Index}/{id?}"
    );
});
//Tek bir Area olacaksa asagidaki kodu kullanabilirim.
//Bu kodu kullanirsam Area-Admin tarafindaki Controllerda Route[....] helperini kullanmama gerek kalmaz.
//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapAreaControllerRoute(
//    name: "Admin",
//    areaName: "Admin",
//    pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
//    );
//    endpoints.MapDefaultControllerRoute();
//});


app.Run();
