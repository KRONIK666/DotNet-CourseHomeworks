using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples
{
    class CollegeTeacher : Teacher
    {
        private string teachingUniversity;
        public string TeachingUniversity
        {
            get { return teachingUniversity; }
            set { teachingUniversity = value; }
        }

        public void CheckHomework()
        {
        }
    }
}