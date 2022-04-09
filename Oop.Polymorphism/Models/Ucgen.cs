namespace Oop.Polymorphism.Models;

public  class Ucgen:Sekil
{
    public double Z { get; set; }
    public override double AlanHesapla()
    {
        return (X * Z) / 2;
    }

    public override double CevreHesapla()
    {
        
        double H=Math.Sqrt((X * X) + (Z * Z));
        return H + X + Z;
    }
}