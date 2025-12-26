using System;

class TemperatureArray
{
    // автоматическое свойство (массив температур)
    public double[] Temperatures { get; private set; } = new double[7];

    // индексатор
    public double this[int day]
    {
        get
        {
            if (day < 0 || day > 6)
                throw new IndexOutOfRangeException("День должен быть от 0 до 6");
            return Temperatures[day];
        }
        set
        {
            if (day < 0 || day > 6)
                throw new IndexOutOfRangeException("День должен быть от 0 до 6");
            Temperatures[day] = value;
        }
    }

    // метод вычисления средней температуры
    public double GetAverageTemperature()
    {
        double sum = 0;
        foreach (double t in Temperatures)
            sum += t;

        return sum / Temperatures.Length;
    }
}

class Program
{
    static void Main()
    {
        TemperatureArray week = new TemperatureArray();

        week[0] = -10; // понедельник
        week[1] = -12;
        week[2] = -11;
        week[3] = -13;
        week[4] = -14;
        week[5] = -15;
        week[6] = -9;  // воскресенье

        Console.WriteLine("Средняя температура за неделю: " +
            week.GetAverageTemperature());
    }
}
