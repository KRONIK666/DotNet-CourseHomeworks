using System;

namespace ClassesAndObjects2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] brand = new string[10];

            for (int i = 0; i < brand.Length; i++)
            {
                if (i >= 0 && i <= 4)
                {
                    Console.Write("Enter automobile brand: ");
                    brand[i] = Console.ReadLine();
                }

                if (i > 4 && i < brand.Length)
                {
                    Console.Write("Enter SUV brand: ");
                    brand[i] = Console.ReadLine();
                }
            } Console.WriteLine();

            int[] price = new int[10];

            for (int i = 0; i < price.Length; i++)
            {
                Console.Write("Enter price for every vehicle: ");
                price[i] = int.Parse(Console.ReadLine());
            } Console.WriteLine();

            float[] consumption = new float[10];

            for (int i = 0; i < consumption.Length; i++)
            {
                Console.Write("Enter average fuel consumption: ");
                consumption[i] = float.Parse(Console.ReadLine());
            } Console.WriteLine();

            Console.WriteLine("Vehicles Info:");
            Console.WriteLine("------------------------------");

            for (int i = 0; i < 10; i++)
            {
                if (i >= 0 && i <= 4)
                {
                    Automobile carInfo = new Automobile(price[i], consumption[i]);
                    carInfo.Price = price[i];
                    carInfo.FuelConsumption = consumption[i];

                    Console.WriteLine("Brand of automobile: " + brand[i]);
                    Console.WriteLine("Price: " + carInfo.Price + " EUR");
                    Console.WriteLine("Fuel consumption: " + carInfo.FuelConsumption);
                    Console.WriteLine();
                }

                if (i > 4 && i < 10)
                {
                    bool highRoad = true;

                    SUV carInfo = new SUV(price[i], highRoad);
                    carInfo.Price = price[i];
                    carInfo.HighRoad = highRoad;

                    if (consumption[i] < 10)
                    {
                        carInfo.HighRoad = false;
                        Console.WriteLine("Brand of SUV: " + brand[i]);
                        Console.WriteLine("Price: " + carInfo.Price + " EUR");
                        Console.WriteLine("High road: " + carInfo.HighRoad);
                    }

                    if (consumption[i] >= 10)
                    {
                        carInfo.HighRoad = true;
                        Console.WriteLine("Brand of SUV: " + brand[i]);
                        Console.WriteLine("Price: " + carInfo.Price + " EUR");
                        Console.WriteLine("High road: " + carInfo.HighRoad);
                    } Console.WriteLine();
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine();
        }
    }
}