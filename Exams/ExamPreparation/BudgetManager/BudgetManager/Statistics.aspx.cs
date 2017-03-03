using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace BudgetManager
{
    public partial class Statistics : System.Web.UI.Page
    {
        private double weeklySumCalculated = 0;
        private double monthlySumCalculated = 0;
        private double annualSumCalculated = 0;

        List<Expense> expenses = new List<Expense>();

        protected void Page_Load(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["FilePath"]))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    string[] expense = line.Split('|');

                    if (DateTime.Now.AddDays(-7) <= DateTime.Parse(expense[0]))
                    {
                        weeklySumCalculated += double.Parse(expense[2]);
                    }

                    if (DateTime.Now.AddDays(-30) <= DateTime.Parse(expense[0]))
                    {
                        monthlySumCalculated += double.Parse(expense[2]);
                    }

                    if (DateTime.Now.AddDays(-365) <= DateTime.Parse(expense[0]))
                    {
                        annualSumCalculated += double.Parse(expense[2]);
                    }

                    line = reader.ReadLine();
                }
            }

            weeklySum.Text = weeklySumCalculated.ToString();
            monthlySum.Text = monthlySumCalculated.ToString();
            annualSum.Text = annualSumCalculated.ToString();
        }

        protected void calculateBtn_Click(object sender, EventArgs e)
        {
            weeklySumCalculated = 0;
            monthlySumCalculated = 0;
            annualSumCalculated = 0;

            using (StreamReader reader = new StreamReader(ConfigurationManager.AppSettings["FilePath"]))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    string[] expense = line.Split('|');

                    if (DateTime.Now.AddDays(-7) <= DateTime.Parse(expense[0]))
                    {
                        weeklySumCalculated += double.Parse(expense[2]);
                    }

                    if (DateTime.Now.AddDays(-30) <= DateTime.Parse(expense[0]))
                    {
                        monthlySumCalculated += double.Parse(expense[2]);
                    }

                    if (DateTime.Now.AddDays(-365) <= DateTime.Parse(expense[0]))
                    {
                        annualSumCalculated += double.Parse(expense[2]);
                    }

                    line = reader.ReadLine();
                }
            }

            weeklySum.Text = weeklySumCalculated.ToString();
            monthlySum.Text = monthlySumCalculated.ToString();
            annualSum.Text = annualSumCalculated.ToString();
        }
    }
}