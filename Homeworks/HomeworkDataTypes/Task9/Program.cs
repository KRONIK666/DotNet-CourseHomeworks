using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string myString = Console.ReadLine();

            Console.Write("Show symbol number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("The symbol is: " + myString[n]);
            Console.WriteLine();
        }
    }
}