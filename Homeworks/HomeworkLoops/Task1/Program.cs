using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter another number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int c = 0;
            int result = 1;

            if (a > b)
            {
                c = b;
            }
            else if (a < b)
            {
                c = a;
            }
            else if (a == b)
            {
                c = a;
            }

            for (int i = 1; i <= c; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    result = i;
                }
            }
            Console.WriteLine("Highest divisor of both number: " + result);
            Console.WriteLine();
        }
    }
}