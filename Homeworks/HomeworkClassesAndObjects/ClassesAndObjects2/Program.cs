using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] model = new string[10];

            for (int i = 0; i < model.Length; i++)
            {
                Console.Write("Enter 5 cars and 5 SUVs: ");
                model[i] = Console.ReadLine();
            }

            Console.WriteLine();
            int[] price = new int[10];

            for (int i = 0; i < price.Length; i++)
            {
                Console.Write("Enter its price: ");
                price[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            float[] consumption = new float[10];

            for (int i = 0; i < consumption.Length; i++)
            {
                Console.Write("Enter avarege fuel consumption: ");
                consumption[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            bool[] highRoad = new bool[10];

            for (int i = 0; i < highRoad.Length; i++)
            {
                if (consumption[i] < 10)
                {
                    highRoad[i] = false;
                }
                if (consumption[i] >= 10)
                {
                    highRoad[i] = true;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Cars info:");
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                if (highRoad[i] == false)
                {
                    Automobile carInfo = new Automobile(price[i], consumption[i]);
                    Console.WriteLine("Model of car: " + model[i]);
                    Console.WriteLine("Price: " + carInfo.Price + " EUR");
                    Console.WriteLine("Fuel consumption: " + carInfo.FuelConsumption);
                    Console.WriteLine("High road: " + highRoad[i]);
                    Console.WriteLine();
                }
                if (highRoad[i] == true)
                {
                    SUV carInfo = new SUV(price[i], highRoad[i]);
                    Console.WriteLine("Model of car: " + model[i]);
                    Console.WriteLine("Price: " + carInfo.Price + " EUR");
                    Console.WriteLine("Fuel consumption: " + consumption[i]);
                    Console.WriteLine("High road: " + carInfo.HighRoad);
                    Console.WriteLine();
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }
    }
}