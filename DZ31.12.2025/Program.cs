using System;
using System.Collections.Generic;

class Backpack
{
    public string Color { get; set; }
    public string Brand { get; set; }
    public string Material { get; set; }
    public double Weight { get; set; }   // кг
    public double Volume { get; set; }   // литры

    public List<string> Contents { get; set; }

    public Backpack(string color, string brand, string material,
                    double weight, double volume)
    {
        Color = color;
        Brand = brand;
        Material = material;
        Weight = weight;
        Volume = volume;
        Contents = new List<string>();
    }

    public void AddItem(string item)
    {
        Contents.Add(item);
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Цвет: {Color}");
        Console.WriteLine($"Фирма: {Brand}");
        Console.WriteLine($"Ткань: {Material}");
        Console.WriteLine($"Вес: {Weight} кг");
        Console.WriteLine($"Объем: {Volume} л");
        Console.WriteLine("Содержимое: " +
            (Contents.Count > 0 ? string.Join(", ", Contents) : "пусто"));
    }
}
class Program
{
    static void Main()
    {
        Backpack backpack = new Backpack("Черный", "Nike", "Нейлон", 1.2, 25);

        backpack.AddItem("Книга");
        backpack.AddItem("Ноутбук");
        backpack.AddItem("Бутылка воды");

        backpack.ShowInfo();
    }
}
