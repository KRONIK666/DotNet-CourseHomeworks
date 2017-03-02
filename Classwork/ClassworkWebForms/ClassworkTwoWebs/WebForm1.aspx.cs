using System;

namespace ClassworkTwoWebs
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void button_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm2.aspx");
        }

        protected void text_CheckedChanged(object sender, EventArgs e)
        {
            if (text.Checked == true && choice.SelectedIndex != 0)
            {
                button.Enabled = true;
            }
        }

        protected void choice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (text.Checked == true && choice.SelectedIndex != 0)
            {
                button.Enabled = true;
            }
        }
    }
}