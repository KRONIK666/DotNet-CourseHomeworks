using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibrarySystem
{
    public class Book
    {
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private string author;
        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        private string genre;
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