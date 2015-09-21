using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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