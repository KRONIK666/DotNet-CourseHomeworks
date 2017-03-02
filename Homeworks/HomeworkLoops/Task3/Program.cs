using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How much numbers to compare: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int min = int.MaxValue;
            int max = int.MinValue;

            for (int counter = 1; counter <= n; counter++)
            {
                Console.Write("Number {0}: ", counter);
                int number = int.Parse(Console.ReadLine());

                if (number <= min)
                {
                    min = number;
                }
                if (number >= max)
                {
                    max = number;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Lowest number: {0}", min);
            Console.WriteLine("Highest number: {0}", max);
            Console.WriteLine();
        }
    }
}