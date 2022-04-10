using DependencyInjectionAndLoouseCoupling.Services;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

var builder = WebApplication.CreateBuilder(args);

//Built-in IoC Container
builder.Services.AddScoped<SmsService>();
builder.Services.AddControllersWithViews();


var app = builder.Build();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();