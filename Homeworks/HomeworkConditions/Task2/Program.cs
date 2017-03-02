using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your result: ");
            int bonus = int.Parse(Console.ReadLine());

            if (bonus >= 1 && bonus <= 9)
            {
                if (bonus >= 1 && bonus <= 3)
                {
                    Console.Write("Your Bonus Points: ");
                    Console.WriteLine(bonus + 5);
                    Console.WriteLine();
                }
                else if (bonus >= 4 && bonus <= 6)
                {
                    Console.Write("Your Bonus Points: ");
                    Console.WriteLine(bonus * 12);
                    Console.WriteLine();
                }
                else if (bonus >= 7 && bonus <= 9)
                {
                    Console.Write("Your Bonus Points: ");

                    int temp = bonus * 50;
                    Console.WriteLine(temp / 3);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Can't have such result!");
                Console.WriteLine();
            }
        }
    }
}