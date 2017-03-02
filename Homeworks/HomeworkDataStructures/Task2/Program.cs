using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            List<int> temp = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Add number: ");
                list.Add(int.Parse(Console.ReadLine()));
            }

            int numberOfOcurences;

            for (int i = 0; i < list.Count; i++)
            {
                int number = list[i];
                numberOfOcurences = 1;

                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i] == list[j] && i != j)
                    {
                        numberOfOcurences += 1;
                    }
                }

                if (numberOfOcurences % 2 == 1)
                {
                    if (temp.Contains(number))
                    {
                        continue;
                    }
                    else
                    {
                        temp.Add(number);
                    }
                }
            }

            for (int j = 0; j < temp.Count; j++)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == temp[j])
                    {
                        list.Remove(list[i]);
                        i--;
                    }
                }
            }

            if (list.Count == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Your list is empty!");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Your list after removing numbers that occur odd times in the sequence:");
                Console.WriteLine();

                foreach (var item in list)
                {
                    Console.Write(item + " ");
                }

                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
}