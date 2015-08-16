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

        public Professor(string firstName, string familyName, int workingExperience, string university, string title)
            : base(firstName, familyName, workingExperience, university)
        {
            this.title = title;
        }

        public void Say(string firstName, string familyName, string title, int workingExperience)
        {
            Console.WriteLine("Professor {0} {1} has the title {3} and working experience {4} years.", firstName, familyName, title, workingExperience);
        }

        public void CheckHomework()
        {
            Console.WriteLine("Proffesors may also check homeworks!");
        }

        public void WageExams()
        {
            Console.WriteLine("Professors can wage exams!");
        }
    }
}