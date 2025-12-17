using System;

while (true)
{
    Console.WriteLine("\nКалькулятор систем счисления");
    Console.WriteLine("1 - Из 10 в 2");
    Console.WriteLine("2 - Из 2 в 10");
    Console.WriteLine("3 - Из 10 в 16");
    Console.WriteLine("4 - Из 16 в 10");
    Console.WriteLine("0 - Выход");
    Console.Write("Выберите пункт: ");

    string choice = Console.ReadLine();

    if (choice == "0")
        break;

    try
    {
        checked
        {
            switch (choice)
            {
                case "1":
                    Console.Write("Введите десятичное число: ");
                    int dec1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Результат: " + Convert.ToString(dec1, 2));
                    break;

                case "2":
                    Console.Write("Введите двоичное число: ");
                    string bin = Console.ReadLine();
                    int binToDec = Convert.ToInt32(bin, 2);
                    Console.WriteLine("Результат: " + binToDec);
                    break;

                case "3":
                    Console.Write("Введите десятичное число: ");
                    int dec2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Результат: " + Convert.ToString(dec2, 16).ToUpper());
                    break;

                case "4":
                    Console.Write("Введите шестнадцатеричное число: ");
                    string hex = Console.ReadLine();
                    int hexToDec = Convert.ToInt32(hex, 16);
                    Console.WriteLine("Результат: " + hexToDec);
                    break;

                default:
                    Console.WriteLine("Неверный пункт меню");
                    break;
            }
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Ошибка: неверный формат ввода");
    }
    catch (OverflowException)
    {
        Console.WriteLine("Ошибка: число вышло за пределы типа int");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ошибка: " + ex.Message);
    }
}


