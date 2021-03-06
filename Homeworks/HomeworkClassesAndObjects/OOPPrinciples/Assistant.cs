﻿using System;

namespace OOPPrinciples
{
    class Assistant : Lecturer
    {
        private bool chiefAssistant;

        public bool ChiefAssistant
        {
            get { return chiefAssistant; }
            set { chiefAssistant = value; }
        }

        public Assistant(string firstName, string familyName, int workingExperience, string teachingUniversity, bool chiefAssistant)
            : base(firstName, familyName, workingExperience, teachingUniversity)
        {
            this.chiefAssistant = chiefAssistant;
        }

        public void CheckAssistant(string firstName, string familyName, bool chiefAssistant)
        {
            if (chiefAssistant == true)
            {
                Console.WriteLine("Assistant {0} {1} is Chief Assistant.", firstName, familyName);
            }
            else
            {
                Console.WriteLine("Assistant {0} {1} is not Chief Assistant.", firstName, familyName);
            }
        }

        public override void CheckHomeworks()
        {
            Console.WriteLine("This assistant should check homeworks!");
        }

        public void CheckExams()
        {
            Console.WriteLine("This assistant has to check exams!");
        }

        public void WriteScientificArticles()
        {
            Console.WriteLine("This assistant is writing scientific articles!");
        }
    }
}