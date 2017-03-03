namespace LibrarySystem
{
    public class Book
    {
        private string title;
        private string author;
        private double price;
        private string genre;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}|{3}", this.title, this.author, this.price, this.genre);
        }
    }
}