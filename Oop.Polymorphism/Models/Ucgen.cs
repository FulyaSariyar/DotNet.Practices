namespace Oop.Polymorphism.Models;

public  class Ucgen:Dikdörtgen
{
    public override double AlanHesapla()
    {
        return base.AlanHesapla() / 2;
    }

    public override double CevreHesapla()
    {
        return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2))+X+Y;
    }
}