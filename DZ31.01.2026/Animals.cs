using System;

// ===== ТРАВОЯДНЫЕ =====
public abstract class Herbivore
{
    public int Weight { get; protected set; }
    public bool Life { get; set; } = true;

    public abstract void EatGrass();
}

public class Wildebeest : Herbivore
{
    public Wildebeest()
    {
        Weight = 100;
    }

    public override void EatGrass()
    {
        Weight += 10;
        Console.WriteLine($"Гну ест траву. Вес = {Weight}");
    }
}

public class Bison : Herbivore
{
    public Bison()
    {
        Weight = 120;
    }

    public override void EatGrass()
    {
        Weight += 10;
        Console.WriteLine($"Бизон ест траву. Вес = {Weight}");
    }
}

// ===== ХИЩНИКИ =====
public abstract class Carnivore
{
    public int Power { get; protected set; }

    public abstract void Eat(Herbivore herbivore);
}

public class Lion : Carnivore
{
    public Lion()
    {
        Power = 110;
    }

    public override void Eat(Herbivore herbivore)
    {
        if (!herbivore.Life) return;

        if (Power > herbivore.Weight)
        {
            Power += 10;
            herbivore.Life = false;
            Console.WriteLine($"Лев съел травоядное. Сила = {Power}");
        }
        else
        {
            Power -= 10;
            Console.WriteLine($"Лев не смог съесть. Сила = {Power}");
        }
    }
}

public class Wolf : Carnivore
{
    public Wolf()
    {
        Power = 100;
    }

    public override void Eat(Herbivore herbivore)
    {
        if (!herbivore.Life) return;

        if (Power > herbivore.Weight)
        {
            Power += 10;
            herbivore.Life = false;
            Console.WriteLine($"Волк съел травоядное. Сила = {Power}");
        }
        else
        {
            Power -= 10;
            Console.WriteLine($"Волк не смог съесть. Сила = {Power}");
        }
    }
}
