using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of 1st array: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] arrayOne = new int[n];
            int[] arrayTwo = new int[arrayOne.Length];

            for (int i = 0; i < arrayOne.Length; i++)
            {
                Console.Write("Enter next element: ");
                arrayOne[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Your 2nd array is:");
            Console.WriteLine();

            foreach (var item in arrayOne)
            {
                Console.WriteLine(item);
            } Console.WriteLine();
        }
    }
}