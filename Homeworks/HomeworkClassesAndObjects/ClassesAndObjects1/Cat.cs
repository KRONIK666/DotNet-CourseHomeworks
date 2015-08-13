using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects1
{
    class Cat
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Say()
        {
            Console.WriteLine("The cat {0} is {1} years old.", name, age);
        }
    }
}