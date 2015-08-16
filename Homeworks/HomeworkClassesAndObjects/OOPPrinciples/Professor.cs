using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    class Professor : Lecturer
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public void Say(string firstName, string familyName, string title, int workingExperience)
        {
            Console.WriteLine("Professor {0} {1} has the title {3} and working experience {4} years.", firstName, familyName, title, workingExperience);
        }

        public void CheckHomework()
        {
        }

        public void WageExams()
        {
        }
    }
}