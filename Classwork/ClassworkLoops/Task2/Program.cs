using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;

            for (int i = 0; i <= int.MaxValue; i++)
            {
                Console.Write("Enter a number: ");
                int n = int.Parse(Console.ReadLine());

                if (n == 0)
                {
                    Console.WriteLine("Sum is: " + sum + " The End!");
                    Console.WriteLine();
                    break;
                }

                sum = n + sum;
                Console.WriteLine("Sum is: " + sum);
                Console.WriteLine();
            }
        }
    }
}