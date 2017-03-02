namespace ClassworkDataStructures
{
    class Company
    {
        private string name;
        private int numberOfEmployees;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int NumberOfEmployees
        {
            get { return numberOfEmployees; }
            set { numberOfEmployees = value; }
        }

        public override string ToString()
        {
            return this.name + " has " + this.numberOfEmployees + " employees.";
        }
    }
}