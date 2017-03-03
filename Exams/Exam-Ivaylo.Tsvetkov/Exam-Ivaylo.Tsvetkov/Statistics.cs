namespace Exam_Ivaylo.Tsvetkov
{
    public class Statistics
    {
        private string country;
        private string capital;
        private double population;

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }

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