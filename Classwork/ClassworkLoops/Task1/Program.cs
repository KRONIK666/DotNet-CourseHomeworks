using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}