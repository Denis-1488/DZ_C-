using System;
using System.Collections;
using System.Collections.Generic;

// Базовый класс
class SeaCreature
{
    public string Name { get; set; }
    public SeaCreature(string name) => Name = name;
    public override string ToString() => Name;
}

// Жители океанариума
class Shark : SeaCreature
{
    public Shark(string name) : base(name) { }
}

class Dolphin : SeaCreature
{
    public Dolphin(string name) : base(name) { }
}

class Octopus : SeaCreature
{
    public Octopus(string name) : base(name) { }
}

// Океанариум с поддержкой foreach
class Oceanarium : IEnumerable<SeaCreature>
{
    private List<SeaCreature> creatures = new();

    public void Add(SeaCreature creature) => creatures.Add(creature);

    public IEnumerator<SeaCreature> GetEnumerator() => creatures.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

// Проверка
class Program
{
    static void Main()
    {
        Oceanarium oceanarium = new();

        oceanarium.Add(new Shark("Акула"));
        oceanarium.Add(new Dolphin("Дельфин"));
        oceanarium.Add(new Octopus("Осьминог"));

        foreach (var creature in oceanarium)
        {
            Console.WriteLine(creature);
        }
    }
}
