using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To input an integer enter 1");
            Console.WriteLine("To input a double enter 2");
            Console.WriteLine("To input a string enter 3");

            Console.WriteLine();
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter an integer: ");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + (a + 1));
                    break;
                case 2:
                    Console.Write("Enter a double: ");
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine("Result: " + (b + 1));
                    break;
                case 3:
                    Console.Write("Enter a string: ");
                    string c = Console.ReadLine();
                    Console.WriteLine("Result: " + c + "*");
                    break;
                default:
                    Console.WriteLine("I said a choice between 1, 2 or 3!");
                    break;
            } Console.WriteLine();
        }
    }
}