using System;

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
            int maxcount = 1;
            int maxvalue = 0;
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
                    count++;
                    maxvalue = myArray[i];

                    for (int j = 0; j < myArray.Length; j++)
                    {
                        if (maxvalue == myArray[j] && j != i)
                        {
                            if (count > maxcount)
                            {
                                maxcount = count;
                                maxvalue = myArray[i];
                            }
                        }
                        if (n == 1)
                        {
                            maxvalue = myArray[i];
                            count = 1;
                        }
                    }
                }
                Console.WriteLine("Most frequent element is " + maxvalue + " and occurs " + maxcount + " times.");
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