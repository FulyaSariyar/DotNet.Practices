namespace DependencyInjectionAndLoouseCoupling.Models;

public class SmsModel
{
    public string Message  { get; set; }
    public List<string> Numbers { get; set; } = new();
    
}