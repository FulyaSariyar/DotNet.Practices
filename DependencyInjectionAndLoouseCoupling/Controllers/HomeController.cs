using DependencyInjectionAndLoouseCoupling.Models;
using DependencyInjectionAndLoouseCoupling.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjectionAndLoouseCoupling.Controllers;

public class HomeController:Controller
{
    private readonly SmsService _smsService;

    public HomeController(SmsService smsService)
    {
        _smsService = smsService;
    }
    
    public IActionResult Index()
    {
        
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