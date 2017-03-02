using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter another number: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int result = x % y;
            Console.WriteLine("Result: " + result);
            Console.WriteLine();
        }
    }
}