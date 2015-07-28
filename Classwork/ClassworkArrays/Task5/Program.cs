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
            Console.Write("How many numbers to enter: ");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];
            int sum = 0;
            Console.WriteLine();

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Enter next element: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Your numbers are:");
            foreach (var item in myArray)
            {
                Console.WriteLine(item);
            }
            for (int i = 0; i < myArray.Length; i++)
            {
                sum = myArray[i] + sum;
                if (sum == s)
                {
                    Console.WriteLine("Yes!");
                    continue;
                }
                else
                {
                    Console.WriteLine("No!");
                    break;
                }
            }
        }
    }
}