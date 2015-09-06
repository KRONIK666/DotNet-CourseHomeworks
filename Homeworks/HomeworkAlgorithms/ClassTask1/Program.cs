using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Enter number to fill the array: ");
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.Write("Enter a number to check if it exists in the array: ");
            int n = int.Parse(Console.ReadLine());

            int temp = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length; j++)
                {
                    if (myArray[i] < myArray[j])
                    {
                        temp = myArray[i];
                        myArray[i] = myArray[j];
                        myArray[j] = temp;
                    }
                }
            }

            int index = Array.BinarySearch(myArray, n);

            if (index == -1)
            {
                Console.WriteLine();
                Console.WriteLine("This number doesn't exist in the array!");
                Console.WriteLine();
            }
            else
            {
                while (n == myArray[index])
                {
                    index++;
                }
                Console.WriteLine();
                Console.WriteLine("The next bigger number in the array is: " + myArray[index]);
                Console.WriteLine();
            }
        }
    }
}