using System;
using System.Configuration;
using System.IO;

namespace Exam_Ivaylo.Tsvetkov
{
    public partial class Home_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Statistics statistics = new Statistics()
            {
                Country = countryTextBox.Text,
                Capital = capitalTextBox.Text,
                Population = int.Parse(populationTextBox.Text),
            };

            using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["FilePath"], true))
            {
                writer.WriteLine(statistics);
            }

            countryTextBox.Text = "";
            capitalTextBox.Text = "";
            populationTextBox.Text = "";
        }
    }
}