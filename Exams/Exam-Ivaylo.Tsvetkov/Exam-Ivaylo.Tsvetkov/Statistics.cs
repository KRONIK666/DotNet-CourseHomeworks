using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exam_Ivaylo.Tsvetkov
{
    public class Statistics
    {
        private string country;
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        private string capital;
        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }

        private double population;
        public double Population
        {
            get { return population; }
            set { population = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}", this.country, this.capital, this.population);
        }
    }
}