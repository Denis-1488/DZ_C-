using System;
using System.Collections.Generic;
using System.Text;

class Program2
{
    static void Main()
    {
        RunTest(100_000);
        RunTest(500_000);
        RunTest(4_000_000);

        Console.WriteLine("\nВсе тесты завершены");
        Console.ReadKey();
    }

    static void RunTest(int size)
    {
        Console.WriteLine("\n==============================");
        Console.WriteLine($"ТЕСТ: {size} объектов");

        using (Program1 allocator = new Program1())
        {
            allocator.Allocate(size);
            allocator.SimulateWork();
            allocator.ForceGC();
        }

        // Проверка финализатора
        GC.Collect();
        GC.WaitForPendingFinalizers();
    }
}

