using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudgetManager
{
    public class Expense
    {
        private DateTime dateOfExpense;
        public DateTime DateOfExpense
        {
            get { return dateOfExpense; }
            set { dateOfExpense = value; }
        }

        private string expenseType;
        public string ExpenseType
        {
            get { return expenseType; }
            set { expenseType = value; }
        }

        private double cost;
        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}", this.dateOfExpense.ToShortDateString(), this.expenseType, this.cost);
        }
    }
}