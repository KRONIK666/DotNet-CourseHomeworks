using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word here: ");
            string word = Console.ReadLine();

            Console.Write("Your word backwards is: ");
            for (int i = word.Length - 1; i >= 0; i--)
            {
                Console.Write(word[i]);
            } Console.WriteLine();
            Console.WriteLine();
        }
    }
}