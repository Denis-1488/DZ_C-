using System.Collections.Generic;

// ===== АБСТРАКТНАЯ ФАБРИКА =====
public abstract class Continent
{
    public abstract List<Herbivore> CreateHerbivores();
    public abstract List<Carnivore> CreateCarnivores();
}

// ===== КОНТИНЕНТЫ =====
public class Africa : Continent
{
    public override List<Herbivore> CreateHerbivores()
    {
        return new List<Herbivore>
        {
            new Wildebeest()
        };
    }

    public override List<Carnivore> CreateCarnivores()
    {
        return new List<Carnivore>
        {
            new Lion()
        };
    }
}

public class NorthAmerica : Continent
{
    public override List<Herbivore> CreateHerbivores()
    {
        return new List<Herbivore>
        {
            new Bison()
        };
    }

    public override List<Carnivore> CreateCarnivores()
    {
        return new List<Carnivore>
        {
            new Wolf()
        };
    }
}
