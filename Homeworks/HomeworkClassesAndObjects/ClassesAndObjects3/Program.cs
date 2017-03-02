using System;

namespace ClassesAndObjects3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter cathetus A of a right triangle: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter cathetus B of a right triangle: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Triangle rightTriangle = new Triangle(a, b);
            rightTriangle.CathetusA = a;
            rightTriangle.CathetusB = b;
            rightTriangle.CalculateHypotenuse(a, b);
            rightTriangle.CalculateAngles(a, b);
            Console.WriteLine();
        }
    }
}