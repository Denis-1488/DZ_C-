using System;

class Journal
{
    private string title;
    private int foundationYear;
    private string description;
    private string phone;
    private string email;

    public Journal()
    {
        title = "";
        foundationYear = 0;
        description = "";
        phone = "";
        email = "";
    }

    //ввод данных
    public void InputData()
    {
        Console.Write("Введите название журнала: ");
        title = Console.ReadLine();

        Console.Write("Введите год основания: ");
        foundationYear = int.Parse(Console.ReadLine());

        Console.Write("Введите описание журнала: ");
        description = Console.ReadLine();

        Console.Write("Введите контактный телефон: ");
        phone = Console.ReadLine();

        Console.Write("Введите контактный email: ");
        email = Console.ReadLine();
    }

    //вывода данных
    public void PrintData()
    {
        Console.WriteLine("\nИнформация о журнале:");
        Console.WriteLine($"Название: {title}");
        Console.WriteLine($"Год основания: {foundationYear}");
        Console.WriteLine($"Описание: {description}");
        Console.WriteLine($"Телефон: {phone}");
        Console.WriteLine($"Email: {email}");
    }

    // Методы доступа
    public string GetTitle() => title;
    public void SetTitle(string value) => title = value;
    public int GetFoundationYear() => foundationYear;
    public void SetFoundationYear(int value) => foundationYear = value;
    public string GetDescription() => description;
    public void SetDescription(string value) => description = value;
    public string GetPhone() => phone;
    public void SetPhone(string value) => phone = value;
    public string GetEmail() => email;
    public void SetEmail(string value) => email = value;
}
class Program
{
    static void Main()
    {
        Journal journal = new Journal();

        journal.InputData();
        journal.PrintData();

        journal.SetTitle("Tech World");
        Console.WriteLine("\nНовое название журнала: " + journal.GetTitle());
    }
}
