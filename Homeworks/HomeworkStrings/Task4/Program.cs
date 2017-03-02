using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "apple";
            string text = "This is an apple. This is an orange. I love apples and oranges.";

            Console.WriteLine("Text: \"This is an apple. This is an orange. I love apples and oranges.\"");
            Console.WriteLine("Keyword: \"apple\"");

            Console.WriteLine();
            Console.WriteLine("The text containing only sentences with the keyword:");

            string[] split = text.Split('.');

            for (int i = 0; i < split.Length; i++)
            {
                if (split[i].Contains(word))
                {
                    Console.Write(split[i] + ".");
                }
            } Console.WriteLine();
            Console.WriteLine();
        }
    }
}