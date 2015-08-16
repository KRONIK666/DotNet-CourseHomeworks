using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    class SchoolTeacher : Teacher
    {
        private string classesList;

        public SchoolTeacher()
        {
            this.classesList = "Class 9A";
            this.classesList = "Class 9B";
            this.classesList = "Class 10A";
            this.classesList = "Class 10B";
            this.classesList = "Class 12A";
        }

        public void TeachingClass(string classesList)
        {
            Console.WriteLine("This school teacher teaches classes " + classesList);
        }

        public void CheckHomework()
        {
        }

        public void EntertainKids()
        {
        }
    }
}