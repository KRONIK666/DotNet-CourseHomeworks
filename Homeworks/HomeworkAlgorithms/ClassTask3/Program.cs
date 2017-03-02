using System;

namespace ClassTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 250;
            int max = 0;
            int[] myArray = new int[n];

            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                myArray[i] = random.Next(0, 1000000);
            }

            int maxElement = Environment.TickCount;
            Console.WriteLine("Max element is: " + FindMaxElement(myArray, max));
            Console.WriteLine("Finding max element time in miliseconds: " + (Environment.TickCount - maxElement));
            Console.WriteLine();

            int quickSort = Environment.TickCount;
            QuicksortArray(myArray, 0, n - 1);
            Console.WriteLine("Quicksorting time in miliseconds: " + (Environment.TickCount - quickSort));
            Console.WriteLine();

            int print = Environment.TickCount;
            PrintArray(myArray);
            Console.WriteLine("Printing time in miliseconds: " + (Environment.TickCount - print));
            Console.WriteLine();
        }

        static int FindMaxElement(int[] array, int max)
        {
            max = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            } return max;
        }

        static void QuicksortArray(int[] array, int left, int right)
        {
            int temp = 0;
            int i = left, j = right;
            int pivot = array[(left + right) / 2];

            while (i <= j)
            {
                while (array[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (array[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;

                    i++;
                    j--;
                }

                if (left < j)
                {
                    QuicksortArray(array, left, j);
                }

                if (i < right)
                {
                    QuicksortArray(array, i, right);
                }
            }
        }

        static void PrintArray(int[] array)
        {
            Console.WriteLine("The array has been sorted as follows:");
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            } Console.WriteLine();
        }
    }
}