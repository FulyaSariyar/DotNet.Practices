namespace Oop.Polymorphism.Models;

public abstract class Sekil
{
    public double X { get; set; }
    public DateTime CreatedDate { get; set; }

    public Sekil()
    {
            this.CreatedDate=DateTime.Now;
    }

    public virtual double AlanHesapla()
    {

        return X * X;
    }
    // public virtual double CevreHesapla()
    // {
    //     return 4 * X;
    // }

    public abstract double CevreHesapla();
}

