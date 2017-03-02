using System;

namespace Methods4
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                DefineNumber(num);
                Console.WriteLine();
            }
        }

        private static void DefineNumber(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("The number is Even!");
            }
            if (num % 2 == 1)
            {
                Console.WriteLine("The number is Odd!");
            }
        }
    }
}