using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader original = new StreamReader("original.txt"))
            {
                int lineNumber = 0;
                string line = original.ReadLine();

                while (line != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 == 0)
                    {
                        StreamWriter even = new StreamWriter("even.txt", true);
                        {
                            even.WriteLine(line);
                        } even.Close();
                    }
                    else
                    {
                        StreamWriter odd = new StreamWriter("odd.txt", true);
                        {
                            odd.WriteLine(line);
                        } odd.Close();
                    }
                    line = original.ReadLine();
                }
            }
            Console.WriteLine("Your text is separated by even and odd lines in two separated files.");
            Console.WriteLine("Check your folder to see the result!");
            Console.WriteLine();
        }
    }
}