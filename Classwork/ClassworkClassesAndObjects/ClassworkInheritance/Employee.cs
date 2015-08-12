using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassworkInheritance
{
    class Employee
    {
        private int workingHours;
        public int WorkingHours
        {
            get { return workingHours; }
            set { workingHours = value; }
        }

        private int salary;
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee(int workingHours, int salary)
        {
            this.workingHours = workingHours;
            this.salary = salary;
        }
    }
}