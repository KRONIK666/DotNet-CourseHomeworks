using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exam_Ivaylo.Tsvetkov
{
    public partial class Search_Page : System.Web.UI.Page
    {
        private static List<Statistics> info = Database.GetResults();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            List<Statistics> results = new List<Statistics>();

            foreach (Statistics item in info)
            {
                if (item.Country.ToLower().Contains(countryTextBox.Text.ToLower()))
                {
                    results.Add(item);
                }
            }
            infoRepeater.DataSource = results;
            infoRepeater.DataBind();
        }
    }
}