using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = null;
            ReadFile("news.txt");
            WriteFile("result.txt", result);
        }

        static void ReadFile(string filename)
        {
            using (StreamReader read = new StreamReader(filename))
            {
                string text = read.ReadToEnd();

                Console.WriteLine("Match Of The Day:");
                Console.WriteLine();
                Console.WriteLine(text);
                Console.WriteLine();
            }
        }

        static void WriteFile(string filename, string result)
        {
            using (StreamWriter write = new StreamWriter(filename))
            {
                result = "United took the win with 3:1 over Liverpool!";
                write.Write(result);

                Console.WriteLine(result);
                Console.WriteLine();
            }
        }
    }
}