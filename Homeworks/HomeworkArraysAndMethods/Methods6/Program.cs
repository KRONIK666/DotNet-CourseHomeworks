using System;

namespace Methods6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("{0}", n);
            Console.WriteLine("! = " + Factorial(n));
            Console.WriteLine();
        }

        private static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
    }
}