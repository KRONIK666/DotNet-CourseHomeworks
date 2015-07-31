using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sum to compare with possible sums: ");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.Write("How many numbers to enter: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] myArray = new int[n];
            bool[] checkSum = new bool[s + 1];
            int checker = int.MinValue;

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Enter next element: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Your numbers are:");
            Console.WriteLine();

            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }

            foreach (var item in myArray)
            {
                if (item > s)
                {
                    continue;
                }
                for (int i = 0; i < checkSum.Length; i++)
                {
                    if (checkSum[i] == true && checker != 1)
                    {
                        checkSum[i + item] = true;
                        checker = i + item;
                    }
                } checkSum[item] = true;
            }
        }
    }
}