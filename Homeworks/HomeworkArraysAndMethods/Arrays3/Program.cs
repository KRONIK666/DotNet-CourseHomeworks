using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];

            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i * 10;
                Console.WriteLine("Index " + i + " is: " + myArray[i]);
            } Console.WriteLine();
        }
    }
}