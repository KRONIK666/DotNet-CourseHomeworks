namespace ClassworkInheritance
{
    class Policeman : Employee
    {
        private string rang;

        public string Rang
        {
            get { return rang; }
            set { rang = value; }
        }

        public Policeman(int workingHours, int salary, string rang)
            : base(workingHours, salary)
        {
            this.rang = rang;
        }
    }
}