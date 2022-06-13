using DependencyInjectionAndLoouseCoupling.Services.EmailService;
using DependencyInjectionAndLoouseCoupling.Services.SmsService;

var builder = WebApplication.CreateBuilder(args);

//Built-in IoC Container
builder.Services.AddScoped<ISmsService, SmsService>();
builder.Services.AddTransient<IMailService, SmtpMailService>();
builder.Services.AddControllersWithViews();


var app = builder.Build();

app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();