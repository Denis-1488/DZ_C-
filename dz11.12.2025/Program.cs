// №1

//using System;


//namespace dz11_12._2025
//{
//    class Program
//    {
//        static void Main()
//        {
//            PrintSquare(5, '*');
//        }

//        static void PrintSquare(int size, char symbol)
//        {
//            for (int i = 0; i < size; i++)
//            {
//                for (int j = 0; j < size; j++)
//                {
//                    Console.Write(symbol);
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}

//№2

//bool IsPalindrome(int number)
//{
//    string s = number.ToString();
//    string reversed = new string(s.Reverse().ToArray());
//    return s == reversed;
//}

//// Пример вызова:
//Console.WriteLine(IsPalindrome(1221)); // true
//Console.WriteLine(IsPalindrome(7854)); // false
