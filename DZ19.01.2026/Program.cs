namespace DZ19._01._2026
{
    using System;

    class Program
    {
        static void Main()
        {
            // Тестирование работы класса
            Play play1 = new Play("Гамлет", "Уильям Шекспир", "Трагедия", 1601);
            play1.Print();

            // Создание объекта в отдельном блоке
            CreateAndDeletePlay();

            // Принудительный вызов сборщика мусора
            GC.Collect();
            GC.WaitForPendingFinalizers();

            Console.WriteLine("\nСборка мусора завершена.");
        }

        static void CreateAndDeletePlay()
        {
            Play play2 = new Play("Ревизор", "Николай Гоголь", "Комедия", 1836);
            play2.Print();
        }
    }

    public class Play
    {
        // Свойства
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }

        // Конструктор
        public Play(string title, string author, string genre, int year)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Year = year;
            Console.WriteLine("Объект Play создан");
        }

        // Метод вывода информации
        public void Print()
        {
            Console.WriteLine("\nИнформация о пьесе:");
            Console.WriteLine($"Название: {Title}");
            Console.WriteLine($"Автор: {Author}");
            Console.WriteLine($"Жанр: {Genre}");
            Console.WriteLine($"Год выпуска: {Year}");
        }

        // Деструктор
        ~Play()
        {
            Console.WriteLine($"Объект Play \"{Title}\" уничтожен");
        }
    }


}
