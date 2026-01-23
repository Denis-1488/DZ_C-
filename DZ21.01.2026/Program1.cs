using System;
using System.Diagnostics;

public class Program1 : IDisposable
{
    private byte[][] data;
    private bool disposed = false;

    public void Allocate(int size)
    {
        Console.WriteLine($"Выделяем память: {size} объектов");

        Stopwatch sw = Stopwatch.StartNew();

        data = new byte[size][];
        for (int i = 0; i < size; i++)
            data[i] = new byte[100];

        sw.Stop();
        Console.WriteLine($"Время выделения памяти: {sw.ElapsedMilliseconds} ms");

        PrintGeneration("После создания");
    }

    public void SimulateWork()
    {
        Console.WriteLine("\nСимуляция активной работы");

        Stopwatch sw = Stopwatch.StartNew();

        for (int i = 0; i < data.Length; i += 2)
            data[i] = null;

        sw.Stop();
        Console.WriteLine($"Время работы: {sw.ElapsedMilliseconds} ms");
    }

    public void ForceGC()
    {
        Console.WriteLine("\nПринудительный вызов GC");

        Stopwatch sw = Stopwatch.StartNew();

        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        sw.Stop();
        Console.WriteLine($"Время GC: {sw.ElapsedMilliseconds} ms");

        PrintGeneration("После GC");
    }

    private void PrintGeneration(string title)
    {
        if (data == null) return;

        Console.WriteLine($"\n{title}:");
        Console.WriteLine($"Поколение массива: {GC.GetGeneration(data)}");
        Console.WriteLine($"Поколение объекта[0]: {GC.GetGeneration(data[0])}");
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposed) return;

        if (disposing)
            data = null;

        disposed = true;
        Console.WriteLine("Dispose вызван");
    }

    ~Program1()
    {
        Console.WriteLine("Деструктор вызван");
        Dispose(false);
    }
}
