using System;

interface IPrintable { void Print(); }
interface IScannable { void Scan(); }
interface ICopyable { void Copy(); }

abstract class OfficeDevice
{
    public string Name { get; }
    public bool On { get; private set; }

    protected OfficeDevice(string name) => Name = name;
    public void TurnOn() => On = true;
    public void TurnOff() => On = false;
}

class Printer : OfficeDevice, IPrintable
{
    public Printer(string n) : base(n) { }
    public void Print() { if (On) Console.WriteLine($"{Name} print"); }
}

class Scanner : OfficeDevice, IScannable
{
    public Scanner(string n) : base(n) { }
    public void Scan() { if (On) Console.WriteLine($"{Name} scan"); }
}

class Copier : OfficeDevice, ICopyable
{
    public Copier(string n) : base(n) { }
    public void Copy() { if (On) Console.WriteLine($"{Name} copy"); }
}

class Mfu : OfficeDevice, IPrintable, IScannable, ICopyable
{
    public Mfu(string n) : base(n) { }
    public void Print() { if (On) Console.WriteLine($"{Name} print"); }
    public void Scan() { if (On) Console.WriteLine($"{Name} scan"); }
    public void Copy() { if (On) Console.WriteLine($"{Name} copy"); }
}

class Office
{
    OfficeDevice[] devices;
    public Office(OfficeDevice[] d) => devices = d;

    public void TurnOnAll() { foreach (var d in devices) d.TurnOn(); }
    public void TurnOffAll() { foreach (var d in devices) d.TurnOff(); }

    public void StartPrint() { foreach (var d in devices) if (d is IPrintable p) p.Print(); }
    public void StartScan() { foreach (var d in devices) if (d is IScannable s) s.Scan(); }
    public void StartCopy() { foreach (var d in devices) if (d is ICopyable c) c.Copy(); }
}

class Program
{
    static void Main()
    {
        OfficeDevice[] devices =
        {
            new Printer("HP"),
            new Scanner("Canon"),
            new Copier("Xerox"),
            new Mfu("Epson")
        };

        var office = new Office(devices);

        office.TurnOnAll();
        office.StartPrint();
        office.StartScan();
        office.StartCopy();
        office.TurnOffAll();
    }
}



