using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Form2 secondForm = new Form2();
            secondForm.Show();
            secondForm.FormClosing += secondForm_FormClosing;
        }

        private void secondForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TextBox secondFormTextBox = ((sender as Form).Controls.Find("textBox", true)[0]) as TextBox;
            label.Text = secondFormTextBox.Text;
        }
    }
}