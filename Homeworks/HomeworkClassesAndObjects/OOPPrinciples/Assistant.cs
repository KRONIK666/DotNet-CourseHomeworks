using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    class Assistant : Lecturer
    {
        private bool assistant;

        public Assistant(string firstName, string familyName, int workingExperience, string university, bool assistant)
            : base(firstName, familyName, workingExperience, university)
        {
            this.assistant = assistant;
        }

        public void Check(string firstName, string familyName, bool assistant)
        {
            if (assistant == true)
            {
                Console.WriteLine("Assistant {0} {1} is Chief Assistant.", firstName, familyName);
            }
            else
            {
                Console.WriteLine("Assistant {0} {1} is not Chief Assistant.", firstName, familyName);
            }
        }

        public void CheckHomework()
        {
            Console.WriteLine("Assistants are supposed to check homeworks!");
        }

        public void CheckExams()
        {
            Console.WriteLine("Assistants are supposed to check also exams!");
        }

        public void WriteScientificArticles()
        {
            Console.WriteLine("Assistants can write scientific articles!");
        }
    }
}