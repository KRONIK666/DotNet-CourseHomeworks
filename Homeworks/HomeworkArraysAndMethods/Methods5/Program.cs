using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Symmetric numbers between 10 and 999 are:");
            Console.WriteLine();

            for (int i = 10; i <= 999; i++)
            {
                PrintSymmetric(i);
            }
            Console.WriteLine();
        }

        private static void PrintSymmetric(int num)
        {
            if (num < 10 || num > 999)
            {
                Console.WriteLine("The number is out of range!");
                return;
            }
            if (num % 11 == 0 && num < 100)
            {
                Console.WriteLine(num);
            }
            if (num >= 100)
            {
                int firstNumber = num / 100;
                int lastNumber = num % 10;

                if (firstNumber == lastNumber)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}