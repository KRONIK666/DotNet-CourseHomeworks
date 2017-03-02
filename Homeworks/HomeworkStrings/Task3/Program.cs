using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Ня";
            string text = "Ня, Ня, Ня, Ня, Ня, Ня, Ня, Ня, Нямам петна под мишниците!";

            Console.WriteLine("Word to be counted: \"Ня\"");
            Console.WriteLine("Your text: \"Ня, Ня, Ня, Ня, Ня, Ня, Ня, Ня, Нямам петна под мишниците!\"");

            Console.WriteLine();
            Console.WriteLine("Times that your word occures: {0} times", CountStringOccurrences(text, word));
            Console.WriteLine();
        }

        public static int CountStringOccurrences(string text, string word)
        {
            int count = 0;
            int i = 0;

            while ((i = text.IndexOf(word, i)) != -1)
            {
                i += word.Length;
                count++;
            }

            return count;
        }
    }
}