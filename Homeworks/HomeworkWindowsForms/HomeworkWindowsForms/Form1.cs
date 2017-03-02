using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HomeworkWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            label4.Text = "";
            label5.Text = "";

            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                label4.Text = "Trying to add an empty field! Please, enter required info!";
            }
            else if ((textBox3.Text).Contains('@') == false || (textBox3.Text).Contains('.') == false)
            {
                label5.Text = "Wrong e-mail format entered! Enter a valid e-mail!";
            }
            else
            {
                label4.Text = "";
                label5.Text = "";

                using (StreamWriter text = new StreamWriter("info.txt", true))
                {
                    text.WriteLine("User:");
                    text.WriteLine(label1.Text + " " + textBox1.Text);
                    text.WriteLine(label2.Text + " " + textBox2.Text);
                    text.WriteLine(label3.Text + " " + textBox3.Text);
                    text.WriteLine("");
                }
            }
        }
    }
}