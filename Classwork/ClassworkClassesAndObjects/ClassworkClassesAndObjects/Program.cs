using System;

namespace ClassworkClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ivo = new Person();
            ivo.Name = "Ivaylo";
            ivo.Age = 30;
            ivo.Email = "ivaylo@abv.bg";

            Console.WriteLine("Name: " + ivo.Name);
            Console.WriteLine("E-mail: " + ivo.Email);
            Console.WriteLine("Age: " + ivo.Age);
            Console.WriteLine();

            Person pavel = new Person("Pavel", 28, "pavel@abv.bg");
            Console.WriteLine("Name: " + pavel.Name);
            Console.WriteLine("E-mail: " + pavel.Email);
            Console.WriteLine("Age: " + pavel.Age);
            Console.WriteLine();

            Person vlady = new Person();
            vlady.Name = "Vladislav";
            vlady.Age = 32;
            vlady.Email = "vladislav@abv.bg";

            Console.WriteLine("Name: " + vlady.Name);
            Console.WriteLine("E-mail: " + vlady.Email);
            Console.WriteLine("Age: " + vlady.Age);
            Console.WriteLine();
        }
    }
}