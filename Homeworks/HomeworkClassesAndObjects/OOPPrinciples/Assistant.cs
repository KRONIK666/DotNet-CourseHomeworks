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
        public bool Assistant
        {
            get { return assistant; }
            set { assistant = value; }
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

        public void WriteScientificArticles(bool articles)
        {
            if (articles == true)
            {
                Console.WriteLine("This assistant can write scientific articles.");
            }
            else
            {
                Console.WriteLine("This assistant can't write scientific articles.");
            }
        }

        public void CheckHomework()
        {
        }

        public void CheckExams()
        {
        }
    }
}