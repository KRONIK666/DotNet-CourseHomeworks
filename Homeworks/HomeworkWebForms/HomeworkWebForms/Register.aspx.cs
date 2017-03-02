using System;
using System.IO;

namespace HomeworkWebForms
{
    public partial class Register : System.Web.UI.Page
    {
        protected void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "";

            if (TextBox1.Text == "" || TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "")
            {
                label6.Text = "Empty field is registered! Please, fill in a valid information!";
            }
            else if (TextBox2.Text != TextBox3.Text)
            {
                label6.Text = "Invalid password inserted! Please, re-enter the same password!";
            }
            else
            {
                using (StreamWriter info = new StreamWriter(Server.MapPath("register.txt"), true))
                {
                    info.WriteLine(label1.Text + " " + TextBox1.Text);
                    info.WriteLine(label2.Text + " " + TextBox2.Text);
                    info.WriteLine(label3.Text + " " + TextBox3.Text);
                    info.WriteLine(label4.Text + " " + TextBox4.Text);
                    info.WriteLine(label5.Text + " " + TextBox5.Text);
                    info.WriteLine("");
                }
            }
        }
    }
}