using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of both arrays: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter next element of 1st array: ");
                firstArray[i] = int.Parse(Console.ReadLine());
            } Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter next element of 2nd array: ");
                secondArray[i] = int.Parse(Console.ReadLine());
            } Console.WriteLine();

            bool compare = firstArray.SequenceEqual(secondArray);
            Console.WriteLine("First array equals to second array: " + compare);
            Console.WriteLine();
        }
    }
}