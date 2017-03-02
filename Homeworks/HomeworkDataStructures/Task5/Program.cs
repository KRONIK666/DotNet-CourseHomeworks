using System;
using System.Collections.Generic;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> words = new Dictionary<int, string>();
            Dictionary<string, int> occurrences = new Dictionary<string, int>();

            string word;

            for (int i = 0; i < 20; i++)
            {
                Console.Write("Fill in a new word: ");
                word = Console.ReadLine();
                words.Add(i + 1, word);
            }

            foreach (string value in words.Values)
            {
                if (occurrences.ContainsKey(value))
                {
                    occurrences[value]++;
                }
                else
                {
                    occurrences[value] = 1;
                }
            } Console.WriteLine();

            foreach (var item in occurrences)
            {
                if (item.Value == 1)
                {
                    Console.WriteLine("The word \"{0}\" occurs {1} time in your Dictionary;", item.Key, item.Value);
                }
                else
                {
                    Console.WriteLine("The word \"{0}\" occurs {1} times in your Dictionary;", item.Key, item.Value);
                }
            } Console.WriteLine();
        }
    }
}