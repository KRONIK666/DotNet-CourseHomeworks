using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Count sum between min and max? ");
            Console.Write("If min is 1, enter max: ");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (max < 10 || max > 30000)
            {
                Console.WriteLine("Try again! Max must be in the interval between 10 and 30000!");
            }
            else
            {
                int min = 1;
                int sum = 0;
                Recursive(min, max, ref sum);

                Console.WriteLine("The sum of all numbers: " + sum);
            } Console.WriteLine();
        }

        private static int Recursive(int min, int max, ref int sum)
        {
            sum += min;

            if (min >= max)
            {
                return 1;
            }

            Recursive(min + 1, max, ref sum);
            return 1;
        }
    }
}