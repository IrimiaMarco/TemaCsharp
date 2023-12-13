using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemaCsharp
{
    internal class Car
    {
        public string color;
        public string name;
        public int year;
        public int maxSpeed;
        public Car(string nameN, string colorN, int yearN, int maxN)
        {
            name = nameN;
            color = colorN;
            year = yearN;
            maxSpeed = maxN;

        }

        public Car(string nameN)
        {
            name = nameN;
        }

        public void fullThrottle()
        {
            Console.WriteLine(name + " is going at the speed of " + maxSpeed);
        }

    }
}
