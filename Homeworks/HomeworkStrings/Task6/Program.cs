using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader original = new StreamReader("original.txt"))
            {
                string text = original.ReadToEnd();
                Console.WriteLine("Your original text:");
                Console.WriteLine();
                Console.WriteLine(text);
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------------------");
                Console.WriteLine("Your edited text saved in your copy file:");
                Console.WriteLine();

                using (StreamWriter copy = new StreamWriter("copy.txt"))
                {
                    char[] marks = new char[] { '.', ',', '-', '!', '?', '(', ')', '"', ';', ':' };

                    string[] split = text.Split(marks);

                    for (int i = 0; i < split.Length; i++)
                    {
                        Console.Write(split[i]);
                        copy.Write(split[i]);
                    } Console.WriteLine();
                } Console.WriteLine();
            }
        }
    }
}