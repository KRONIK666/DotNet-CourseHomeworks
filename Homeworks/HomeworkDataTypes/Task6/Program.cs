using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write down a string: ");
            string a = Console.ReadLine();

            Console.Write("Write down another string: ");
            string b = Console.ReadLine();
            Console.WriteLine();

            string combination = a + "|" + b;
            Console.WriteLine("Combined string: " + combination);
            Console.WriteLine();
        }
    }
}