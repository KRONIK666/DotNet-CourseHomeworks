using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassworkExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write("Result of multiplication: " + n * 5);
                Console.WriteLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("This is not a number!");
            }
            finally
            {
                Console.WriteLine();
                Console.WriteLine("End of program!");
                Console.WriteLine();
            }
        }
    }
}