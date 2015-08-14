using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects4
{
    class Celsius
    {
        private double degrees;
        public double Degrees
        {
            get { return degrees; }
            set { degrees = value; }
        }

        public Celsius()
        {
        }

        public void ConvertDegrees(double celsius, double fahrenheit)
        {
            fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine("{0}°C in Fahrenheit is {1}°F", celsius, fahrenheit);
        }
    }
}