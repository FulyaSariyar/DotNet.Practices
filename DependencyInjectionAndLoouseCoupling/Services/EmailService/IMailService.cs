using DependencyInjectionAndLoouseCoupling.Models;

namespace DependencyInjectionAndLoouseCoupling.Services.EmailService
{
    public interface IMailService
    {
        Task SendMailAsync(MailModel model);
    }
}