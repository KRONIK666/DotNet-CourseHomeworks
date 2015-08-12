using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassworkClassesAndObjects
{
    class Person
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

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Person()
        {
        }

        public Person(string name, int age, string email)
        {
            this.name = name;
            this.age = age;
            this.email = email;
        }
    }
}