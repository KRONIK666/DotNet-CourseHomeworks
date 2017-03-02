using System;

namespace OOPPrinciples
{
    class Teacher : Person
    {
        private string teachingSubject;

        public string TeachingSubject
        {
            get { return teachingSubject; }
            set { teachingSubject = value; }
        }

        public Teacher()
        {

        }

        public Teacher(string firstName, string familyName, int workingExperience, string teachingSubject)
            : base(firstName, familyName, workingExperience)
        {
            this.teachingSubject = teachingSubject;
        }

        public void SayGoodbye()
        {
            Console.WriteLine("This teacher says \"Goodbye!\" to students every day!");
        }
    }
}