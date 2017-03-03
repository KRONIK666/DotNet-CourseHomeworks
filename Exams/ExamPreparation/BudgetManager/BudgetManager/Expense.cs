using System;

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

        private double cost;
        private string expenseType;

        public double Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public string ExpenseType
        {
            get { return expenseType; }
            set { expenseType = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}", this.dateOfExpense.ToShortDateString(), this.expenseType, this.cost);
        }
    }
}