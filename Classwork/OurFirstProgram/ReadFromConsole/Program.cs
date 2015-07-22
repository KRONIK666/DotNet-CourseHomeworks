using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFromConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine();

            int test;
            Console.Write("Test it!: ");
            bool success = int.TryParse(Console.ReadLine(), out test);
            Console.WriteLine(success);
            Console.WriteLine(test);
            Console.WriteLine();
        }
    }
}