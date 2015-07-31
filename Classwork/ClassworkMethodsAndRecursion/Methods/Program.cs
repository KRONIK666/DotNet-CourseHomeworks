using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array's length: ");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];
            Console.WriteLine();

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Enter element: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Your array backwards is:");
            Console.WriteLine();

            PrintArray(myArray);

            Console.WriteLine();
        }

        private static void PrintArray(int[] myArray)
        {
            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
        }

        Console.Write("Enter length: ");
            int n = int.Parse(Console.ReadLine());
            string[] massive = new string[n];

            for (int i = 0; i < massive.Length; i++)
            {
                Console.Write("Enter element: ");
                massive[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Your array is:");
            Console.WriteLine();

            BuildArray(massive);

            Console.WriteLine();
        }

        private static void BuildArray(string[] massive)
        {
            for (int i = massive.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(massive[i]);
            }
    }
}