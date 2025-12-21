namespace DZ19._12._2025
{
   internal class Program
    {
        class Employee
        {
            public string Name { get; set; }
            public double Salary { get; set; }

            public Employee(string name, double salary)
            {
                Name = name;
                Salary = salary;
            }

            public static Employee operator +(Employee e, double v)
                => new Employee(e.Name, e.Salary + v);

            public static Employee operator -(Employee e, double v)
                => new Employee(e.Name, e.Salary - v);

            public static bool operator ==(Employee a, Employee b)
                => a.Salary == b.Salary;

            public static bool operator !=(Employee a, Employee b)
                => a.Salary != b.Salary;

            public static bool operator >(Employee a, Employee b)
                => a.Salary > b.Salary;

            public static bool operator <(Employee a, Employee b)
                => a.Salary < b.Salary;

            public override bool Equals(object o)
                => o is Employee e && Salary == e.Salary;

            public override int GetHashCode()
                => Salary.GetHashCode();
        
    
    
   class Program
   {
        static void Main()
        {
        var e1 = new Employee("Ivan", 12000);
        var e2 = new Employee("Oleg", 10000);

        e1 += 2000;
        e2 -= 1000;

        Console.WriteLine(e1 > e2);
        Console.WriteLine(e1 == e2);
    }
}
    
    
    
    
    
    
    
    
    
    
    }

    }
}



