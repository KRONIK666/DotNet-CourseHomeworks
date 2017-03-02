using System;

namespace OOPPrinciples
{
    class SchoolTeacher : Teacher
    {
        private string[] teachingClasses = new string[] { "class \"2A\",", "class \"2B\",", "class \"3A\",", "class \"3B\",", "class \"4A\"." };

        public SchoolTeacher()
        {

        }

        public void TeachingClasses()
        {
            Console.Write("He/She teaches classes in:");

            for (int i = 0; i < teachingClasses.Length; i++)
            {
                Console.Write(" " + teachingClasses[i]);
            } Console.WriteLine();
        }

        public void EntertainKids()
        {
            Console.WriteLine("This school teacher has to find way to entertain kids!");
        }
    }
}