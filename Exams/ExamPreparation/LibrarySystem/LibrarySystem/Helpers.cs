using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace LibrarySystem
{
    public class Helpers
    {
        public static List<Book> GetBooks()
        {
            List<Book> books = new List<Book>();

            using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["FilePath"]))
            {
                string line = reader.ReadLine();
                do
                {
                    string[] book = line.Split('|');
                    books.Add(new Book()
                    {
                        Title = book[0],
                        Author = book[1],
                        Price = double.Parse(book[2]),
                        Genre = book[3]
                    });
                    line = reader.ReadLine();
                } while (line != null);
            }
            return books;
        }
    }
}