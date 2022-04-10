using DependencyInjectionAndLoouseCoupling.Models;
using DependencyInjectionAndLoouseCoupling.Services;
using DependencyInjectionAndLoouseCoupling.Services.SmsService;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

var builder = WebApplication.CreateBuilder(args);

//Built-in IoC Container
builder.Services.AddScoped<ISmsService,SmsService>();
builder.Services.AddControllersWithViews();


var app = builder.Build();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();