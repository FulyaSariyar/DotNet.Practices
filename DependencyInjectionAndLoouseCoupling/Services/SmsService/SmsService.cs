using System.Diagnostics;
using DependencyInjectionAndLoouseCoupling.Models;

namespace DependencyInjectionAndLoouseCoupling.Services.SmsService;

public class SmsService: ISmsService
{
    // A firmasının sms servisini kullanarak bir sms gönderen method oluşturduk
    public void Send(SmsModel model)
    {
        Console.WriteLine($"{model.Message} {model.Numbers.Count} kişiye yollandı");
    }
}