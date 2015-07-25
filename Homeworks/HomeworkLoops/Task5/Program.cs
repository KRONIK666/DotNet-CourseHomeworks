using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to find its factoriel: ");
            int n = int.Parse(Console.ReadLine());
            long fn = 1;

            for (int counter = 1; counter <= n; counter++)
            {
                fn *= counter;
            }
            Console.WriteLine("{0}! = {1}", n, fn);
            Console.WriteLine();

            Console.Write("Enter another number to find its factoriel: ");
            int k = int.Parse(Console.ReadLine());
            long fk = 1;

            for (int counter = 1; counter <= k; counter++)
            {
                fk *= counter;
            }
            Console.WriteLine("{0}! = {1}", k, fk);
            Console.WriteLine();

            int result = (n - k);
            long fnk = 1;

            for (int counter = 1; counter <= result; counter++)
            {
                fnk *= counter;
            }
            Console.Write("({0}-{1})! = ", n, k);
            Console.WriteLine(fnk);
            Console.WriteLine();

            long total = (fn * fk) / fnk;
            Console.Write("{0}!*{1}! / ({2}-{3})! = ", n, k, n, k);
            Console.WriteLine(total);
            Console.WriteLine();
        }
    }
}