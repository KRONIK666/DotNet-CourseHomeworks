using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write down a string: ");
            string a = Console.ReadLine();

            Console.Write("Write down another string: ");
            string b = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Does 1st string contains the 2nd string?");
            Console.WriteLine(a.Contains(b));
            Console.WriteLine();
        }
    }
}