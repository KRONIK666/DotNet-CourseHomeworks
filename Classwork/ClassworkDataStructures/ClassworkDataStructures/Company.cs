using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassworkDataStructures
{
    class Company
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int numberOfEmployees;
        public int NumberOfEmployees
        {
            get { return numberOfEmployees; }
            set { numberOfEmployees = value; }
        }

        public override string ToString()
        {
            return this.name + " has " + this.numberOfEmployees + " employees.";
        }
    }
}