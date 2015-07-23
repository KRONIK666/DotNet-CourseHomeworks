using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 0:
                    Console.WriteLine();
                    Console.WriteLine("Нула");
                    break;
                case 1:
                    Console.WriteLine();
                    Console.WriteLine("Едно");
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Две");
                    break;
                case 3:
                    Console.WriteLine();
                    Console.WriteLine("Три");
                    break;
                case 4:
                    Console.WriteLine();
                    Console.WriteLine("Четири");
                    break;
                case 5:
                    Console.WriteLine();
                    Console.WriteLine("Пет");
                    break;
                case 6:
                    Console.WriteLine();
                    Console.WriteLine("Шест");
                    break;
                case 7:
                    Console.WriteLine();
                    Console.WriteLine("Седем");
                    break;
                case 8:
                    Console.WriteLine();
                    Console.WriteLine("Осем");
                    break;
                case 9:
                    Console.WriteLine();
                    Console.WriteLine("Девет");
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Числото не попада в интервала!");
                    break;
            } Console.WriteLine();
        }
    }
}