using System.Diagnostics;
using DependencyInjectionAndLoouseCoupling.Models;

namespace DependencyInjectionAndLoouseCoupling.Services;

public class SmsService
{
    // A firmasının sms servisini kullanarak bir sms gönderen method oluşturduk
    public void Send(SmsModel model)
    {
        Console.WriteLine($"{model.Message} {model.Numbers.Count} kişiye yollandı");
    }
}