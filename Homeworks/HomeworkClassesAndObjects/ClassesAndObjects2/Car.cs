namespace ClassesAndObjects2
{
    class Car
    {
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Car(int price)
        {
            this.price = price;
        }
    }
}