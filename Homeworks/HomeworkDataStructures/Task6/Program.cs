using System;
using System.Collections.Generic;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> temp = new Dictionary<int, string>();
            Dictionary<string, int> uniqueWords = new Dictionary<string, int>();

            string text = "This program, accepts a text and pops as a result all words that are unique. This program works fine and pops all unique words.";
            Console.WriteLine("Your text:");
            Console.WriteLine();
            Console.WriteLine(text);

            int key = 0;
            int occurrences = 0;
            char[] marks = new char[] { '.', ',', ' ' };
            string[] split = text.Split(marks);

            foreach (string item in split)
            {
                key += 1;
                temp.Add(key, item);

                if (item == "")
                {
                    temp.Remove(key);
                    key--;
                }
            }

            foreach (var item in temp)
            {
                occurrences = 1;

                if (uniqueWords.ContainsKey(item.Value))
                {
                    uniqueWords.Remove(item.Value);
                    occurrences++;
                    uniqueWords.Add(item.Value, occurrences);
                }
                else
                {
                    uniqueWords.Add(item.Value, occurrences);
                }
            } Console.WriteLine("----------------------------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine("The unique words in your text are: ");
            Console.WriteLine();

            foreach (var item in uniqueWords)
            {
                if (item.Value == 1)
                {
                    Console.Write(item.Key + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}