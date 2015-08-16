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

        private int maximumLectures = 10;

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
            Console.WriteLine("Lecturers also can check homeworks!");
        }

        public void WageExercise(int a)
        {
            Console.WriteLine("Some lecturers can wage exercises in {0}!", a);
        }

        public void WageExercise(int a, int b)
        {
            Console.WriteLine("Other lecturers can wage exercises in {0} and {1}!", a, b);
        }

        public void WageExercise(int a, int b, int c)
        {
            Console.WriteLine("There also are lecturers that can wage exercises in {0}, {1} and {2}!", a, b, c);
        }

        public void Greet()
        {
            Console.WriteLine("Good afternoon students!");
        }
    }
}