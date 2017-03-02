using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 7 != 0 && i % 11 != 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            } Console.WriteLine();
        }
    }
}