using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Book> books = Helpers.GetBooks();

            booksRepeater.DataSource = books;
            booksRepeater.DataBind();
        }
    }
}