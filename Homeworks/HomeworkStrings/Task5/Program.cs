using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a mathematical expression: ");
            string mathematicalExpression = Console.ReadLine();

            bool correctBrackets = true;
            int open = 0;
            int close = 0;

            for (int i = 0; i < mathematicalExpression.Length; i++)
            {
                char symbol = mathematicalExpression[i];

                if (symbol == '(')
                {
                    open++;
                }
                else if (symbol == ')')
                {
                    close++;

                    if (close > open)
                    {
                        correctBrackets = false;
                        break;
                    }
                }
                else if (symbol == mathematicalExpression.Length - 1 && (close == open))
                {
                    correctBrackets = true;
                }
            }
            Console.WriteLine("Your mathematical expression has correct brackets: " + correctBrackets);
            Console.WriteLine();
        }
    }
}