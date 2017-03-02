using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 1st number: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum of both numbers: " + (x + y));
            Console.WriteLine();
        }
    }
}