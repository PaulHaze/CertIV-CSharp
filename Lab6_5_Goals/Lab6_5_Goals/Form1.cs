using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_5_Goals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal sales = decimal.Parse(txtSales.Text);
            int years = int.Parse(txtYears.Text);

            // initialize the message variable that will contain the final sales totals
            string remainingGoals = "";

            // return the first years sales goal
            lblSalesGoals.Text = "$" + sales;

            // for loop to iterate through the total amount of years and to add 8% each time
            for (int i = 1; i <= years; i++)
            {
                remainingGoals += $"Year {i}:  Sales Target: ${sales}\n";
                sales = CalculateNewGoal(sales);
                
            }
            // output the final message with the years and goals calculated
            lblGoalsRemaining.Text = remainingGoals;
        }

        // function that works out the 8% increase. Takes a double to allow for decimals
        // Used Math.Round to ensure it stays at 2 decimal places
        private decimal CalculateNewGoal(decimal x)
        {
            decimal salesGoal = x + ((x / 100) * 8);
            salesGoal = Math.Round(salesGoal, 2);
            return salesGoal;
        }
    }
}
