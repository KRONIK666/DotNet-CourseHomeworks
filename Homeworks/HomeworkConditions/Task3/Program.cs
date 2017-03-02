using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please, enter a playing card: ");
            string card = (Console.ReadLine());

            switch (card)
            {
                case "2":
                    Console.WriteLine("Valid card!");
                    Console.WriteLine();
                    break;
                case "3":
                    Console.WriteLine("Valid card!");
                    Console.WriteLine();
                    break;
                case "4":
                    Console.WriteLine("Valid card!");
                    Console.WriteLine();
                    break;
                case "5":
                    Console.WriteLine("Valid card!");
                    Console.WriteLine();
                    break;
                case "6":
                    Console.WriteLine("Valid card!");
                    Console.WriteLine();
                    break;
                case "7":
                    Console.WriteLine("Valid card!");
                    Console.WriteLine();
                    break;
                case "8":
                    Console.WriteLine("Valid card!");
                    Console.WriteLine();
                    break;
                case "9":
                    Console.WriteLine("Valid card!");
                    Console.WriteLine();
                    break;
                case "10":
                    Console.WriteLine("Valid card!");
                    Console.WriteLine();
                    break;
                case "J":
                    Console.WriteLine("Valid card!");
                    Console.WriteLine();
                    break;
                case "Q":
                    Console.WriteLine("Valid card!");
                    Console.WriteLine();
                    break;
                case "K":
                    Console.WriteLine("Valid card!");
                    Console.WriteLine();
                    break;
                case "A":
                    Console.WriteLine("Valid card!");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid card!");
                    Console.WriteLine();
                    break;
            }
        }
    }
}