using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
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

            if (1 < k && k < n)
            {
                long result = (fn / fk);
                Console.Write("{0}! / {1}! = ", n, k);
                Console.WriteLine(result);
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Try again!");
                Console.WriteLine("1st number should be bigger than 2nd number!");
                Console.WriteLine();
            }
        }
    }
}