namespace ClassworkInheritance
{
    class Doctor : Employee
    {
        private int dayShifts;
        private int nightShifts;

        public int DayShifts
        {
            get { return dayShifts; }
            set { dayShifts = value; }
        }

        public int NightShifts
        {
            get { return nightShifts; }
            set { nightShifts = value; }
        }

        public Doctor(int workingHours, int salary, int dayShifts, int nightShifts)
            : base(workingHours, salary)
        {
            this.dayShifts = dayShifts;
            this.nightShifts = nightShifts;
        }
    }
}