using System;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            Console.Write("My name is: ");
            string name = Console.ReadLine();

            Console.WriteLine();
            NameYourself(name);
            Console.WriteLine();
        }

        private static void NameYourself(string name)
        {
            Console.WriteLine("Greetings, " + name + "!");
        }
    }
}