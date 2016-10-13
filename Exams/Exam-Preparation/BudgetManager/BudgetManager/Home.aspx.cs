using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BudgetManager
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Expense expense = new Expense()
            {
                DateOfExpense = DateTime.Parse(dateTxtBox.Text),
                ExpenseType = expenseTypeTxtBox.Text,
                Cost = double.Parse(sumTxtBox.Text)
            };
            using (StreamWriter writer = new StreamWriter(ConfigurationManager.AppSettings["FilePath"], true))
            {
                writer.WriteLine(expense);
            }
        }
    }
}