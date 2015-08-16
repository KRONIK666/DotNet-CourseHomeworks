using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    class CollegeTeacher : Teacher
    {
        private string teachingUniversity;

        public CollegeTeacher(string firstName, string familyName, int workingExperience, string teachingSubject, string teachingUniversity)
            : base(firstName, familyName, workingExperience, teachingSubject)
        {
            this.teachingUniversity = teachingUniversity;
        }

        public void CheckHomework()
        {
            Console.WriteLine("Teachers can check homeworks!");
        }
    }
}