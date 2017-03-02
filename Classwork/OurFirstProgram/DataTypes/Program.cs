using System;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 255;
            Console.WriteLine(a);

            short b = 25000;
            Console.WriteLine(b);

            int x = 300000;
            Console.WriteLine(x);

            long y = 24500493049403;
            Console.WriteLine(y);

            object obj = '#';
            Console.WriteLine(obj.GetType());
        }
    }
}