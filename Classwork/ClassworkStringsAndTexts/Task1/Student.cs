using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Student
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string family;
        public string Family
        {
            get { return family; }
            set { family = value; }
        }

        private int facultyNumber;
        public int FacultyNumber
        {
            get { return facultyNumber; }
            set { facultyNumber = value; }
        }

        private int group;
        public int Group
        {
            get { return group; }
            set { group = value; }
        }

        public Student()
        {
        }

        public override string ToString()
        {
            return string.Format("Student {0} {1} has faculty number {2} and is studing in group {3}.", this.name, this.family, this.facultyNumber, this.group);
        }
    }
}