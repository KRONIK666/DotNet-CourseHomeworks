using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 cat names!");
            string[] cats = new string[10];

            for (int i = 0; i < cats.Length; i++)
            {
                Console.Write("Next cat: ");
                cats[i] = Console.ReadLine();
            }

            Console.WriteLine();
            Console.WriteLine("Enter their ages!");
            int[] catsAge = new int[10];

            for (int i = 0; i < catsAge.Length; i++)
            {
                Console.Write("Enter age: ");
                catsAge[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Cats info:");
            Console.WriteLine("------------------------------");

            for (int i = 0; i < 10; i++)
            {
                Cat catInfo = new Cat(cats[i], catsAge[i]);
                catInfo.Say();
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }
    }
}