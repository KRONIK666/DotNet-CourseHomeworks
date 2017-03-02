using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello John, are you ready for the party tonight?";

            Console.WriteLine("Your text is: " + text);
            Console.WriteLine();

            Console.WriteLine("The text starts with \"John\": " + text.StartsWith("John"));
            Console.WriteLine("The text ends with \"!\": " + text.EndsWith("!"));
            Console.WriteLine("The text contains \"party\": " + text.Contains("party"));
            Console.WriteLine();
        }
    }
}