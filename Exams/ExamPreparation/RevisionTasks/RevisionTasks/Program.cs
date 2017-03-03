using System;
using System.Collections.Generic;

namespace RevisionTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 4, 3, 4, 8, 7, 6, 5, 4, 3, 2, 8, 12, 3, 2, 7, 6, 5, 4, 3, 8, 1 };

            List<int> current = new List<int>();
            List<int> longest = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i + 1 < numbers.Length && numbers[i] > numbers[i + 1])
                {
                    current.Add(numbers[i]);
                }
                else
                {
                    current.Add(numbers[i]);
                    if (current.Count > longest.Count)
                    {
                        longest = current;
                    }
                    current = new List<int>();
                    continue;
                }
            }

            foreach (int item in longest)
            {
                Console.WriteLine(item);
            } Console.WriteLine();
        }
    }
}