using System;

namespace OOPPrinciples
{
    class Lecturer : Person
    {
        public const int maximumLecturesPerWeek = 16;

        private string teachingUniversity;

        public string TeachingUniversity
        {
            get { return teachingUniversity; }
            set { teachingUniversity = value; }
        }

        public Lecturer()
        {

        }

        public Lecturer(string firstName, string familyName, int workingExperience, string teachingUniversity)
            : base(firstName, familyName, workingExperience)
        {
            this.teachingUniversity = teachingUniversity;
        }

        public void WageExercise(string a)
        {
            Console.WriteLine("This lecturer can wage exercises in {0}!", a);
        }

        public void WageExercise(string a, string b)
        {
            Console.WriteLine("This lecturer can wage exercises in {0} and {1}!", a, b);
        }

        public void WageExercise(string a, string b, string c)
        {
            Console.WriteLine("This lecturer can wage exercises in {0}, {1} and {2}!", a, b, c);
        }
    }
}