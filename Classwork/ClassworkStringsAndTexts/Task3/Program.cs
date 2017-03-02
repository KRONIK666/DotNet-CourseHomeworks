using System;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader countries = new StreamReader("countries.txt");
            string text = countries.ReadToEnd();
            Console.WriteLine(text);
            Console.WriteLine();
            countries.Close();

            Console.WriteLine("Enter the capital of each country!");
            Console.WriteLine();

            string[] capital = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Capital {0}: ", (i + 1));
                capital[i] = Console.ReadLine();
            }

            using (StreamWriter cities = new StreamWriter("cities.txt"))
            {
                for (int i = 0; i < 5; i++)
                {
                    cities.WriteLine("Capital {0}: {1}", (i + 1), capital[i]);
                }
            } Console.WriteLine();
        }
    }
}