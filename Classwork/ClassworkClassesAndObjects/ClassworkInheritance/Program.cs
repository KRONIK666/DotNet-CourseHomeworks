using System;

namespace ClassworkInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Policeman cop = new Policeman(12, 800, "Deputy");
            Console.WriteLine("Cop Maniac works {0} hours, his salary is {1} dollars.", cop.WorkingHours, cop.Salary);
            Console.WriteLine("He is now officially {0}!", cop.Rang);
            Console.WriteLine();

            Doctor doc = new Doctor(4, 1600, 2, 2);
            Console.WriteLine("Doc works {0} hours on day and night shifts: {1}/{2}.", doc.WorkingHours, doc.DayShifts, doc.NightShifts);
            Console.WriteLine("His salary is {0} pounds.", doc.Salary);
            Console.WriteLine();
        }
    }
}