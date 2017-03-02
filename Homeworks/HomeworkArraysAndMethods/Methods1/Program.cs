using System;

namespace Methods1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter a number: ");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (z > x && z > y)
            {
                Console.WriteLine("The biggest number is: " + z);
            }
            else if (z < x)
            {
                PrintMaxNumber(x, y);
            }
            else if (z < y)
            {
                PrintMaxNumber(x, y);
            }
            Console.WriteLine();
        }

        private static void PrintMaxNumber(int x, int y)
        {
            if (x > y)
            {
                Console.WriteLine("The biggest number is: " + x);
            }
            if (y > x)
            {
                Console.WriteLine("The biggest number is: " + y);
            }
        }
    }
}