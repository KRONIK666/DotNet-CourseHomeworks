using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            float x = float.Parse(Console.ReadLine());

            Console.Write("Divide with an integer: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine();

            float z = x / y;
            Console.WriteLine("Result: " + z);
            Console.WriteLine();
        }
    }
}