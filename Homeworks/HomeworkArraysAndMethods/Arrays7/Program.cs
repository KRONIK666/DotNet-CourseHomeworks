using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of Matrix: ");
            int n = int.Parse(Console.ReadLine());
            int[,] Matrix = new int[n, n];
            Console.WriteLine();

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write("Enter element: ");
                    Matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Your Matrix is:");
            Console.WriteLine();

            for (int i = 0; i < Matrix.GetLength(0); i++)
            {
                for (int j = 0; j < Matrix.GetLength(1); j++)
                {
                    Console.Write(Matrix[j, i] + "\t");
                } Console.WriteLine();
            } Console.WriteLine();
        }
    }
}