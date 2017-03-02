namespace ClassesAndObjects2
{
    class SUV : Car
    {
        private bool highRoad;

        public bool HighRoad
        {
            get { return highRoad; }
            set { highRoad = value; }
        }

        public SUV(int price, bool highRoad)
            : base(price)
        {
            this.highRoad = highRoad;
        }
    }
}