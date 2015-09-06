using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Good morning students, today you will be learning how to order words from a specific text in alphabetical order!";
            Console.WriteLine("Your text is:");
            Console.WriteLine();
            Console.WriteLine(text);

            char[] marks = new char[] { '.', ',', '-', '!', '?', '(', ')', '"', ';', ':' };
            string newText = "";
            string[] tempText = text.Split(marks);

            for (int i = 0; i < tempText.Length; i++)
            {
                newText += tempText[i];
            } text = newText;

            string[] words = text.Split(' ');

            Array.Sort<string>(words);

            Console.WriteLine();
            Console.WriteLine("The words in your text in alphabetical order:");
            Console.WriteLine();

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            } Console.WriteLine();
        }
    }
}