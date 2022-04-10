using DependencyInjectionAndLoouseCoupling.Models;

namespace DependencyInjectionAndLoouseCoupling.Services.SmsService;

public class LogiSmsService
{
    //Logi firmasına ait sms servisi configurasyonu
    public void Send(SmsModel model)
    {
        Console.WriteLine($"LOGISms:{model.Message}{model.Numbers.Count} kişiye yollandı");
    }
}