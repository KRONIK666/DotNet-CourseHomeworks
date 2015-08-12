using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassworkInheritance
{
    class Doctor : Employee
    {
        private int nightShifts;
        public int NightShifts
        {
            get { return nightShifts; }
            set { nightShifts = value; }
        }

        private int dayShifts;
        public int DayShifts
        {
            get { return dayShifts; }
            set { dayShifts = value; }
        }

        public Doctor(int workingHours, int salary, int nightShifts, int dayShifts)
            : base(workingHours, salary)
        {
            this.nightShifts = nightShifts;
            this.dayShifts = dayShifts;
        }
    }
}