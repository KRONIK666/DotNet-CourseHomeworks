using System;
using System.Collections.Generic;

namespace Methods3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNum = new Random();

            for (int j = 1; j <= 10; j++)
            {
                List<int> list = new List<int>();

                for (int i = 0; i < 3; i++)
                {
                    int current = randomNum.Next(1, 100);

                    if (list.Contains(current))
                    {
                        i--;
                    }
                    else
                    {
                        list.Add(current);
                    }
                }

                Console.WriteLine("Randomly generated numbers:");
                Console.WriteLine();

                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }

                Console.WriteLine();
                Console.WriteLine("Result: " + CalculateResult(list[0], list[1], list[2]));
                Console.WriteLine("-------------------------");
            }
        }

        private static int CalculateResult(int x, int y, int z)
        {
            int result = x * y * z;
            return result;
        }
    }
}