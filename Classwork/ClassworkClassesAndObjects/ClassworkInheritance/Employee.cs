namespace ClassworkInheritance
{
    class Employee
    {
        private int workingHours;
        private int salary;

        public int WorkingHours
        {
            get { return workingHours; }
            set { workingHours = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee(int workingHours, int salary)
        {
            this.workingHours = workingHours;
            this.salary = salary;
        }
    }
}