//Задание №1
//namespace DZ07._12._2025
//{
//    class Program
//    {
//        static void Main()
//        {
//            Console.Write("Введите число от 1 до 100: ");
//            if (!int.TryParse(Console.ReadLine(), out int num) || num < 1 || num > 100)
//            {
//                Console.WriteLine("Ошибка: число должно быть в диапазоне 1..100!");
//                return;
//            }
//            if (num % 3 == 0 && num % 5 == 0) Console.WriteLine("Fizz Buzz");
//            else if (num % 3 == 0) Console.WriteLine("Fizz");
//            else if (num % 5 == 0) Console.WriteLine("Buzz");
//            else Console.WriteLine(num);
//        }
//    }
//}

//Задание №3
//namespace DZ07._12._2025 { 

//    using System;

//    class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("Введите 4 цифры отдельно:");
//            string result = "";

//            for (int i = 1; i <= 4; i++)
//            {
//                Console.Write($"Цифра {i}: ");
//                string s = Console.ReadLine();

//                if (s.Length != 1 || !char.IsDigit(s[0]))
//                {
//                    Console.WriteLine("Ошибка: нужно вводить ОДНУ цифру!");
//                    return;
//                }

//                result += s;
//            }

//            Console.WriteLine($"Получившееся число: {result}");
//        }
//    }
//}


//Задание №8

//namespace DZ07._12._2025 { 

//    using System;

//    class Program
//    {
//        static void Main()
//        {
//            Console.Write("Введите число: ");
//            if (!int.TryParse(Console.ReadLine(), out int num) || num < 0)
//            {
//                Console.WriteLine("Ошибка!");
//                return;
//            }

//            string s = num.ToString();
//            int digits = s.Length;
//            int sum = 0;

//            foreach (char c in s)
//            {
//                int d = c - '0';
//                sum += (int)Math.Pow(d, digits);
//            }

//            if (sum == num)
//                Console.WriteLine($"{num} — число Армстронга");
//            else
//                Console.WriteLine($"{num} — НЕ число Армстронга");
//        }
//    }

//}
