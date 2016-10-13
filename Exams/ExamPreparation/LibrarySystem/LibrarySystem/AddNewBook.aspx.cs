using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LibrarySystem
{
    public partial class AddNewBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            resultLabel.Visible = false;
        }

        protected void addBookBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Book bookToAdd = new Book();
                bookToAdd.Title = titleTxtBox.Text;
                bookToAdd.Author = authorTxtBox.Text;
                bookToAdd.Price = double.Parse(priceTxtBox.Text);
                bookToAdd.Genre = genreTxtBox.Text;

                using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["FilePath"], true))
                {
                    writer.WriteLine(bookToAdd);
                }
                resultLabel.Visible = true;
                resultLabel.Text = "Success";
            }
            catch (Exception)
            {
                resultLabel.Visible = true;
                resultLabel.Text = "Something went wrong!";
            }
            
        }
    }
}