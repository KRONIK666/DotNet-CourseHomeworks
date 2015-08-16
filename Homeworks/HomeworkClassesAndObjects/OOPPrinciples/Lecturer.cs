using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    class Lecturer : Person
    {
        private string university;

        private int maximumlectures = 10;

        public Lecturer()
        {
        }

        public Lecturer(string firstName, string familyName, int workingExperience, string university)
            : base(firstName, familyName, workingExperience)
        {
            this.university = university;
        }

        public void CheckHomework()
        {
        }

        public void CheckExercise(int a)
        {
        }

        public void CheckExercise(int a, int b)
        {
        }

        public void CheckExercise(int a, int b, int c)
        {
        }

        public void Greet()
        {
        }
    }
}