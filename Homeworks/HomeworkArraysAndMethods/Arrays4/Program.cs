using System;

namespace Arrays4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array's length: ");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter next element: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.Write("Search Index of element: ");
            int e = int.Parse(Console.ReadLine());

            bool isFound = false;

            for (int i = 0; i < n; i++)
            {
                if (e == myArray[i])
                {
                    Console.WriteLine();
                    Console.WriteLine("The Index is: " + i);
                    Console.WriteLine();
                    isFound = true;
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine();
                Console.WriteLine("Not found!");
                Console.WriteLine();
            }
        }
    }
}