using System;
using System.Collections.Generic;

class Program
{
  
    delegate bool NumberFilter(int number);

    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 8, 13, 21, 34, 55, 89 };

        Show("Четные", numbers, IsEven);
        Show("Нечетные", numbers, IsOdd);
        Show("Простые", numbers, IsPrime);
        Show("Фибоначчи", numbers, IsFibonacci);
    }

   
    static void Show(string title, int[] array, NumberFilter filter)
    {
        Console.Write(title + ": ");
        foreach (int n in array)
            if (filter(n))
                Console.Write(n + " ");
        Console.WriteLine();
    }

    // Четные
    static bool IsEven(int n) => n % 2 == 0;

    // Нечетные
    static bool IsOdd(int n) => n % 2 != 0;

    // Простые числа
    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0)
                return false;
        return true;
    }

    static bool IsFibonacci(int n)
    {
        int a = 0, b = 1;
        while (b < n)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }
        return n == b || n == 0;
    }
}
