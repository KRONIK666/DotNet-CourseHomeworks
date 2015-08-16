using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    class Teacher : Person
    {
        private string teachingSubject;

        public Teacher()
        {
        }

        public Teacher(string firstName, string familyName, int workingExperience, string teachingSubject)
            : base(firstName, familyName, workingExperience)
        {
            this.teachingSubject = teachingSubject;
        }

        public void CheckHomework()
        {
            Console.WriteLine("Teachers can check homeworks!");
        }

        public void Greet()
        {
            Console.WriteLine("Good morning kids!");
        }

        public void SayGoodbye()
        {
            Console.WriteLine("Have a nice evening and prepare your homeworks!");
        }
    }
}