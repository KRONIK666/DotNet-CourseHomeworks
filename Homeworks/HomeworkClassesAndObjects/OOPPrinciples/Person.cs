using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    static class Person
    {
        protected string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        protected string familyName;
        public string FamilyName
        {
            get { return familyName; }
            set { familyName = value; }
        }

        protected int workingExperience;
        public int WorkingExperience
        {
            get { return workingExperience; }
            set { workingExperience = value; }
        }

        public int personCount = 0;
    }
}