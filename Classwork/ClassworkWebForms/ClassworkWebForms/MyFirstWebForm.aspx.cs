using System;

namespace ClassworkWebForms
{
    public partial class MyFirstWebForm : System.Web.UI.Page
    {
        protected void button_Click(object sender, EventArgs e)
        {
            label.Text = "Hello " + text.Text;
        }
    }
}