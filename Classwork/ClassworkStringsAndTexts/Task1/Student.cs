namespace Task1
{
    class Student
    {
        private int group;
        private int facultyNumber;
        private string name;
        private string family;

        public int Group
        {
            get { return group; }
            set { group = value; }
        }

        public int FacultyNumber
        {
            get { return facultyNumber; }
            set { facultyNumber = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Family
        {
            get { return family; }
            set { family = value; }
        }

        public Student()
        {

        }

        public override string ToString()
        {
            return string.Format("Student {0} {1} has faculty number {2} and is studing in group {3}.", this.name, this.family, this.facultyNumber, this.group);
        }
    }
}