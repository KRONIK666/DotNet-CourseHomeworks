using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array's length: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int[] myArray = new int[n];
            int temp = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Enter next element: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < myArray.Length / 2; i++)
            {
                temp = myArray[i];
                myArray[i] = myArray[myArray.Length - i - 1];
                myArray[myArray.Length - i - 1] = temp;
            }

            Console.WriteLine();
            Console.WriteLine("The array is:");
            Console.WriteLine();

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            } Console.WriteLine();
        }
    }
}