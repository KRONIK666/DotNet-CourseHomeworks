using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array's length: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] myArray = new int[n];
            bool symetric = true;

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Enter next element: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < myArray.Length / 2; i++)
            {
                if (myArray[i] != myArray[myArray.Length - i - 1])
                {
                    symetric = false;
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Is myArray symetric?");
            Console.WriteLine();
            Console.WriteLine("Answer: " + symetric);
            Console.WriteLine();
        }
    }
}