using System;

namespace Arrays8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter size of Matrix: ");
            int n = int.Parse(Console.ReadLine());
            int[,] myMatrix = new int[n, n];

            int row = 0;
            int col = 0;
            int rotations = n * n;
            string direction = "right";

            for (int i = 1; i <= rotations; i++)
            {
                if (direction == "right" && (col > n - 1 || myMatrix[col, row] != 0))
                {
                    direction = "down";
                    col--;
                    row++;
                }
                if (direction == "down" && (row > n - 1 || myMatrix[col, row] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                if (direction == "left" && (col < 0 || myMatrix[col, row] != 0))
                {
                    direction = "up";
                    col++;
                    row--;
                }
                if (direction == "up" && (row < 0 || myMatrix[col, row] != 0))
                {
                    direction = "right";
                    row++;
                    col++;
                }

                myMatrix[col, row] = i;

                if (direction == "right")
                {
                    col++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "up")
                {
                    row--;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Your Spiral Matrix is:");
            Console.WriteLine();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(myMatrix[j, i] + "\t");
                } Console.WriteLine();
            } Console.WriteLine();
        }
    }
}