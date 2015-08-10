using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int[] myArray = new int[100];

            for (int i = 1; i <= n; i++)
            {
                myArray[i] = i;
            }

            Console.WriteLine();
            Console.WriteLine("Permutations are:");
            Console.WriteLine();

            Permute(1, n, myArray);
            Console.WriteLine();
        }

        private static void Permute(int x, int y, int[] nums)
        {
            int temp;

            if (x <= y)
            {
                for (int i = x; i <= y; i++)
                {
                    temp = nums[i];

                    for (int j = i; j > x; j--)
                    {
                        nums[j] = nums[j - 1];
                    }

                    nums[x] = temp;
                    Permute(x + 1, y, nums);

                    for (int j = x; j < i; j++)
                    {
                        nums[j] = nums[j + 1];
                    }

                    nums[i] = temp;
                }
            }
            else
            {
                for (int i = 1; i <= y; i++)
                {
                    Console.Write("{0} ", nums[i]);
                } Console.WriteLine();
            }
        }
    }
}