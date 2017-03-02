using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count the area of a rectangle.");
            Console.WriteLine();

            Console.Write("Enter side 'a': ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter side 'b': ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            int area = a * b;
            Console.WriteLine("The area of the rectangle is: " + area);
            Console.WriteLine();
        }
    }
}