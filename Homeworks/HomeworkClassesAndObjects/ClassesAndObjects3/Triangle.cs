using System;

namespace ClassesAndObjects3
{
    class Triangle
    {
        private double cathetusA;
        private double cathetusB;

        public double CathetusA
        {
            get { return cathetusA; }
            set { cathetusA = value; }
        }

        public double CathetusB
        {
            get { return cathetusB; }
            set { cathetusB = value; }
        }

        public Triangle(double cathetusA, double cathetusB)
        {
            this.cathetusA = cathetusA;
            this.cathetusB = cathetusB;
        }

        public void CalculateHypotenuse(double cathetusA, double cathetusB)
        {
            double tempHypotenuse = 0;
            double squaredHypotenuse = tempHypotenuse * tempHypotenuse;

            squaredHypotenuse = (cathetusA * cathetusA) + (cathetusB * cathetusB);
            tempHypotenuse = Math.Sqrt(squaredHypotenuse);

            float hypotenuse = Convert.ToSingle(tempHypotenuse);
            Console.WriteLine("The hypotenuse of the right triangle is: {0} cm.", hypotenuse);
        }

        public void CalculateAngles(double cathetusA, double cathetusB)
        {
            double tempHypotenuse = 0;
            double squaredHypotenuse = tempHypotenuse * tempHypotenuse;

            squaredHypotenuse = (cathetusA * cathetusA) + (cathetusB * cathetusB);
            tempHypotenuse = Math.Sqrt(squaredHypotenuse);

            float hypotenuse = Convert.ToSingle(tempHypotenuse);
            double tempAngle1 = Math.Atan(cathetusA / cathetusB) * (180 / Math.PI);
            double tempAngle2 = Math.Atan(cathetusA / cathetusB) * (180 / Math.PI);
            tempAngle1 = Math.Asin(cathetusA / hypotenuse) * (180 / Math.PI);
            tempAngle2 = Math.Asin(cathetusB / hypotenuse) * (180 / Math.PI);

            int angle1 = Convert.ToInt32(tempAngle1);
            int angle2 = Convert.ToInt32(tempAngle2);
            Console.WriteLine("The right triangle has two acute angles with degrees: {0} and {1}", angle1, angle2);
        }
    }
}