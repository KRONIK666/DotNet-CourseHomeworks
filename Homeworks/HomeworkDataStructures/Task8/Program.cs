using System;
using System.Collections.Generic;
using System.Linq;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] f1 = new int[15];
            int[] f2 = new int[10];
            int[] f3 = new int[17];

            for (int i = 0; i < f1.Length; i++)
            {
                if (i == 0)
                {
                    f1[0] = 1;
                }
                else
                {
                    f1[i] = 2 * f1[i - 1] + 3;
                }
            }

            for (int i = 0; i < f2.Length; i++)
            {
                if (i == 0)
                {
                    f2[0] = 2;
                }
                else
                {
                    f2[i] = 3 * f2[i - 1] + 1;
                }
            }

            for (int i = 0; i < f3.Length; i++)
            {
                if (i == 0)
                {
                    f3[0] = 2;
                }
                else
                {
                    f3[i] = 2 * f3[i - 1] - 1;
                }
            }

            HashSet<int> hash1 = new HashSet<int>(f1);
            HashSet<int> hash2 = new HashSet<int>(f2);
            HashSet<int> hash3 = new HashSet<int>(f3);

            int[] intersectResultOneTwo = hash1.Intersect(hash2).ToArray();
            int[] intersectResultOneThree = hash1.Intersect(hash3).ToArray();
            int[] intersectResultTwoThree = hash2.Intersect(hash3).ToArray();
            int[] intersectResultAll = hash1.Intersect(hash2).Intersect(hash3).ToArray();
            int[] unionResultOneTwo = hash1.Union(hash2).ToArray();
            int[] unionResultOneThree = hash1.Union(hash3).ToArray();
            int[] unionResultTwoThree = hash2.Union(hash3).ToArray();
            int[] unionResultAll = hash1.Union(hash2).Intersect(hash3).ToArray();

            Console.WriteLine("Results of intersections:");
            Console.WriteLine();

            Console.Write("Intersect result between First and Second:");

            foreach (var item in intersectResultOneTwo)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.Write("Intersect result between First and Third: ");

            foreach (var item in intersectResultOneThree)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.Write("Intersect result between Second and Third: ");

            foreach (var item in intersectResultTwoThree)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Intersect result between All:");

            foreach (var item in intersectResultAll)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Results of unions:");
            Console.WriteLine();
            Console.WriteLine("Union result between First and Second:");

            foreach (var item in unionResultOneTwo)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Union result between First and Third:");

            foreach (var item in unionResultOneThree)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Union result between Second and Third:");

            foreach (var item in unionResultTwoThree)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Union result between All: ");

            foreach (var item in unionResultAll)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            Console.WriteLine();
        }
    }
}