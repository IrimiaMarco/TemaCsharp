using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Mustang", "white", 2021, 100);
            Car Opel = new Car("Astra", "blue", 2020, 120);
            Car BMW = new Car("EX5");
            Console.WriteLine(Ford.Name);
            Console.WriteLine(Ford.Year);
            Console.WriteLine(Ford.Color);
            Console.WriteLine(Ford.MaxSpeed);
            Console.WriteLine(Opel.Name);
            Console.WriteLine(Opel.Year);
            Console.WriteLine(Opel.Color);
            Console.WriteLine(Opel.MaxSpeed);
            Console.WriteLine(BMW.Name);
            Console.WriteLine();
            Ford.honk();
            Console.ReadKey();
        }
    }
}
