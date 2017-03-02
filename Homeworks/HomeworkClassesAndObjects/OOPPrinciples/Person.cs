using System;

namespace OOPPrinciples
{
    abstract class Person
    {
        public static int personCount;

        protected string firstName;
        protected string familyName;
        protected int workingExperience;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string FamilyName
        {
            get { return familyName; }
            set { familyName = value; }
        }

        public int WorkingExperience
        {
            get { return workingExperience; }
            set { workingExperience = value; }
        }

        public Person()
        {
            personCount += 1;
        }

        public Person(string firstName, string familyName, int workingExperience)
        {
            this.firstName = firstName;
            this.familyName = familyName;
            this.workingExperience = workingExperience;

            personCount += 1;
        }

        public static int GetPersonCount()
        {
            return personCount;
        }

        public void SayHello()
        {
            Console.WriteLine("He/She has to greet with \"Good afternoon!\" students every day!");
        }

        public virtual void CheckHomeworks()
        {
            Console.WriteLine("He/She is supposed to check homeworks!");
        }
    }
}