using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array's length: ");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[n];

            int count = 0;
            int currentIndex = 0;
            Console.WriteLine();

            if (n > 0 && n <= 100)
            {
                for (int i = 0; i < myArray.Length; i++)
                {
                    Console.Write("Enter next element: ");
                    myArray[i] = int.Parse(Console.ReadLine());
                } Console.WriteLine();

                for (int i = 0; i < myArray.Length; i++)
                {
                    if (myArray[i] == myArray[currentIndex])
                    {
                        count++;
                    }
                    if (n == 1)
                    {
                        currentIndex = i;
                        count = 1;
                    }
                }
                Console.WriteLine("Most frequent element is " + myArray[currentIndex] + " and occurs " + count + " times.");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Enter valid or lower length!");
                Console.WriteLine();
            }
        }
    }
}