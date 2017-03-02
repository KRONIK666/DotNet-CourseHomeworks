using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word here: ");
            string word = Console.ReadLine();
            Console.Write("Enter a text here: ");
            string text = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Your word is uppercased in the text you entered!");
            Console.Write("New text: ");

            string uppercased = text.Replace(word, word.ToUpper());
            Console.WriteLine(uppercased);
            Console.WriteLine();
        }
    }
}