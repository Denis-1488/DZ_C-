using System;
using System.Linq;

class Phone
{
    public string Name;
    public string Manufacturer;
    public int Price;
    public int Year;
}

class Program
{
    static void Main()
    {
        Phone[] phones =
        {
            new Phone { Name="iPhone", Manufacturer="Apple", Price=600, Year=2019 },
            new Phone { Name="Samsung", Manufacturer="Samsung", Price=700, Year=2021 },
            new Phone { Name="Xiaomi", Manufacturer="Xiaomi", Price=300, Year=2020 },
            new Phone { Name="Nokia", Manufacturer="Nokia", Price=150, Year=2018 }
        };

        Console.WriteLine("Кількість телефонів: " + phones.Length);
        Console.WriteLine("Ціна > 100: " + phones.Count(p => p.Price > 100));
        Console.WriteLine("Ціна 400-700: " + phones.Count(p => p.Price >= 400 && p.Price <= 700));
        Console.WriteLine("Apple: " + phones.Count(p => p.Manufacturer == "Apple"));

        var min = phones.OrderBy(p => p.Price).First();
        Console.WriteLine("Мінімальна ціна: " + min.Name);

        var max = phones.OrderByDescending(p => p.Price).First();
        Console.WriteLine("Максимальна ціна: " + max.Name);

        var oldest = phones.OrderBy(p => p.Year).First();
        Console.WriteLine("Найстаріший: " + oldest.Name);

        var newest = phones.OrderByDescending(p => p.Year).First();
        Console.WriteLine("Найновіший: " + newest.Name);

        Console.WriteLine("Середня ціна: " + phones.Average(p => p.Price));

        Console.ReadKey();
    }
}
