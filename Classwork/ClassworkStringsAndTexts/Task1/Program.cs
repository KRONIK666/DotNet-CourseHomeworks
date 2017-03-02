using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] group = new int[] { 1, 1, 2, 3, 3 };
            int[] facultyNumber = new int[] { 455, 381, 220, 113, 666 };
            string[] name = new string[] { "Hristo", "Evgeny", "Miroslav", "Pavel", "Ivaylo" };
            string[] family = new string[] { "Koilov", "Dimitrov", "Punkov", "Penkov", "Tsvetkov" };

            for (int i = 0; i < 5; i++)
            {
                Student studentInfo = new Student();

                studentInfo.Name = name[i];
                studentInfo.Family = family[i];
                studentInfo.Group = group[i];
                studentInfo.FacultyNumber = facultyNumber[i];

                Console.WriteLine(studentInfo);
            } Console.WriteLine();
        }
    }
}