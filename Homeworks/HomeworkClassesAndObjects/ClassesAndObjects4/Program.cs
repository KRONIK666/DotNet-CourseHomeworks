using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Temperature in Celsius °C to convert: ");
            double c = double.Parse(Console.ReadLine());
            double f = 0;
            Console.WriteLine();

            Celsius degrees = new Celsius();
            degrees.Degrees = c;
            degrees.ConvertDegrees(c, f);
            Console.WriteLine();
        }
    }
}