// See https://aka.ms/new-console-template for more information

using Oop.Polymorphism.Models;

Console.WriteLine("Hello, World!");


Kare kare1 = new Kare()
{
    X = 5
};


Console.WriteLine($"Karenin Cevresi:{kare1.CevreHesapla()}");
Console.WriteLine($"Karenin Alanı:{kare1.AlanHesapla()}");

Dikdörtgen dik1 = new Dikdörtgen()
{
    X = 3,
    Y = 4
};

Console.WriteLine($"Dikdörtgen Cevresi:{dik1.CevreHesapla()}");

Console.WriteLine($"Dikdörtgen Alanı:{dik1.AlanHesapla()}");
Ucgen ucgen1 = new Ucgen()
{
    X = 4,
    Y=3
};

Console.WriteLine($"Üçgenin Alanı:{ucgen1.AlanHesapla()}");
Console.WriteLine($"Üçgenin Çevresi:{ucgen1.CevreHesapla()}");

List<Sekil> sekiller=new List<Sekil>();


sekiller.Add(kare1);
sekiller.Add(dik1);
sekiller.Add(ucgen1);

foreach (Sekil item in sekiller)
{
    Console.WriteLine($"Alan:{item.AlanHesapla()}");
    Console.WriteLine($"Cevre:{item.CevreHesapla()}");
}

