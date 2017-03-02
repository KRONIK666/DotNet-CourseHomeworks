using System;

namespace ClassesAndObjects1
{
    class Cat
    {
        private string name;
        private int age;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Cat()
        {

        }

        public void Say()
        {
            Console.WriteLine("The cat {0} is {1} years old.", name, age);
        }
    }
}