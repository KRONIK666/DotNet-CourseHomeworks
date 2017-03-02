namespace OOPPrinciples
{
    class CollegeTeacher : Teacher
    {
        private string teachingCollege;

        public string TeachingCollege
        {
            get { return teachingCollege; }
            set { teachingCollege = value; }
        }

        public CollegeTeacher(string firstName, string familyName, int workingExperience, string teachingSubject, string teachingCollege)
            : base(firstName, familyName, workingExperience, teachingSubject)
        {
            this.teachingCollege = teachingCollege;
        }
    }
}