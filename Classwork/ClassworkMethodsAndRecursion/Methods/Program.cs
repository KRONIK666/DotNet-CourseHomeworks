using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array's length: ");
            int n = int.Parse(Console.ReadLine());
            int[] numArray = new int[n];
            Console.WriteLine();

            Console.Write("Enter array's length: ");
            int s = int.Parse(Console.ReadLine());
            string[] stringArray = new string[s];
            Console.WriteLine();

            for (int i = 0; i < numArray.Length; i++)
            {
                Console.Write("Enter element: ");
                numArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Your num array backwards is:");
            Console.WriteLine();

            PrintArray(numArray);

            Console.WriteLine();

            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.Write("Enter element: ");
                stringArray[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Your string array backwards is:");
            Console.WriteLine();

            PrintArray(stringArray);

            Console.WriteLine();
        }

        private static void PrintArray(int[] numArray)
        {
            for (int i = numArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numArray[i]);
            }
        }

        private static void PrintArray(string[] stringArray)
        {
            for (int i = stringArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(stringArray[i]);
            }
        }
    }
}