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
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (num >= 1 && num <= 5)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("The number is Even!");
                }
                else
                {
                    Console.WriteLine("The number is Odd!");
                }
            }
            else if (num >= 6 && num <= 15)
            {
                if (num % 3 == 0)
                {
                    Console.WriteLine("The number divides to 3");
                }
                else
                {
                    Console.WriteLine("The number doesn't divides to 3");
                }
            }
            else
            {
                if (num > 0)
                {
                    Console.WriteLine("The number is Positive!");
                }
                else if (num < 0)
                {
                    Console.WriteLine("The number is Negative!");
                }
                else
                {
                    Console.WriteLine("The number is Zero!");
                }
            }
            Console.WriteLine();
        }
    }
}