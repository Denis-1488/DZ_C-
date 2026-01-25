using System;
using System.IO;
using System.Text.Json;

class Magazine
{
    public string Title { get; set; }
    public string Publisher { get; set; }
    public DateTime ReleaseDate { get; set; }
    public int Pages { get; set; }

    public void Input()
    {
        Console.Write("Назва журналу: ");
        Title = Console.ReadLine();

        Console.Write("Назва видавництва: ");
        Publisher = Console.ReadLine();

        Console.Write("Дата випуску (рррр-мм-дд): ");
        ReleaseDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Кількість сторінок: ");
        Pages = int.Parse(Console.ReadLine());
    }

    public void Output()
    {
        Console.WriteLine("\nІнформація про журнал:");
        Console.WriteLine($"Назва: {Title}");
        Console.WriteLine($"Видавництво: {Publisher}");
        Console.WriteLine($"Дата випуску: {ReleaseDate:yyyy-MM-dd}");
        Console.WriteLine($"Сторінок: {Pages}");
    }
}

class Program
{
    static void Main()
    {
        string filePath = "magazine.json";

        // Введення
        Magazine magazine = new Magazine();
        magazine.Input();

        // Серіалізація
        string json = JsonSerializer.Serialize(magazine);

        // Збереження у файл
        File.WriteAllText(filePath, json);
        Console.WriteLine("\nЖурнал збережено у файл.");

        // Завантаження з файлу
        string loadedJson = File.ReadAllText(filePath);

        // Десеріалізація
        Magazine loadedMagazine =
            JsonSerializer.Deserialize<Magazine>(loadedJson);

        // Виведення
        loadedMagazine.Output();
    }
}

