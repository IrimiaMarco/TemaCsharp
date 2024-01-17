using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TemaCsharp
{
    class Car : Vehicle
    {


        public Car(string nameName, string colorName, int yearValue, int maxSpeedValue)
        {
            Name = nameName;
            Color = colorName;
            Year = yearValue;
            MaxSpeed = maxSpeedValue;
        }

        public Car(string nameName, string colorName, int yearValue, int maxSpeedValue, string eng_type)
        {
            Name = nameName;
            Color = colorName;
            Year = yearValue;
            MaxSpeed = maxSpeedValue;
            engine_type = eng_type;
        }

        public Car(string nameName)
        {
            Name = nameName;
        }
    }
}
