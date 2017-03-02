using System;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array's length: ");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];

            int a = 0;
            int b = 1;
            int next;

            Console.WriteLine();
            Console.WriteLine("Your Fibonacci is:");
            Console.WriteLine();

            for (int i = 0; i < myArray.Length; i++)
            {
                next = a + b;
                b = a;
                a = next;
                Console.WriteLine(next);
            } Console.WriteLine();
        }
    }
}