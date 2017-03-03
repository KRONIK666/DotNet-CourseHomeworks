using System;
using System.Configuration;
using System.IO;

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