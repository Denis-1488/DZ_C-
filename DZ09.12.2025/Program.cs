//namespace DZ09._12._2025
//{
//    using System;

//    class Program
//    {
//        static void Main()
//        {
//            Console.Write("Введіть речення: ");
//            string text = Console.ReadLine();

//            if (string.IsNullOrWhiteSpace(text))
//            {
//                Console.WriteLine("Слів: 0");
//                return;
//            }

//            string[] words = text.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

//            Console.WriteLine($"Кількість слів: {words.Length}");
//        }
//    }
//}



using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr1 = { 1, 2, 3, 4, 5, 5, 7 };
        int[] arr2 = { 3, 5, 7, 7, 9, 10 };

        int[] common = arr1.Intersect(arr2).Distinct().ToArray();

        Console.WriteLine("Спільні елементи без повторень:");
        Console.WriteLine(string.Join(" ", common));
    }
}
