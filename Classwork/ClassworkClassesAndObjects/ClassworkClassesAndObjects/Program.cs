using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassworkClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ivo = new Person();
            ivo.Name = "Ivaylo";
            ivo.Age = 31;
            ivo.Email = "kronik@abv.bg";

            Console.WriteLine("Name: " + ivo.Name);
            Console.WriteLine("E-mail: " + ivo.Email);
            Console.WriteLine("Age: " + ivo.Age);
            Console.WriteLine();

            Person pavel = new Person("Pavel", 29, "el_pablo@abv.bg");
            Console.WriteLine("Name: " + pavel.Name);
            Console.WriteLine("E-mail: " + pavel.Email);
            Console.WriteLine("Age: " + pavel.Age);
            Console.WriteLine();

            Person vlady = new Person();
            vlady.Name = "Vladislav";
            vlady.Age = 33;
            vlady.Email = "slipsour@abv.bg";

            Console.WriteLine("Name: " + vlady.Name);
            Console.WriteLine("E-mail: " + vlady.Email);
            Console.WriteLine("Age: " + vlady.Age);
            Console.WriteLine();
        }
    }
}