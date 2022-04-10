using DependencyInjectionAndLoouseCoupling.Models;
using DependencyInjectionAndLoouseCoupling.Services;
using DependencyInjectionAndLoouseCoupling.Services.SmsService;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionAndLoouseCoupling.Controllers;

public class HomeController:Controller
{
    private readonly ISmsService _smsService;
    

    public HomeController(ISmsService smsService)
    {
        _smsService = smsService;
    }
    
    public IActionResult Index()
    {
        //var smsService = _smsService as SmsService; //Liskov subs. yer degiştirdiğimizde de düzgün çalışacak!
        _smsService.Send(new SmsModel()
        {
            Message = "Bu bir deneme smsidir.",
            Numbers = new List<string>()
            {
                "123456",
                "342334"
            }
        });
        return View();
    }
}