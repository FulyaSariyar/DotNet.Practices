using DependencyInjectionAndLoouseCoupling.Models;

namespace DependencyInjectionAndLoouseCoupling.Services.SmsService;

public interface ISmsService
{
    void Send(SmsModel model);
}