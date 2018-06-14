using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_2_BankBalance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBalances_Click(object sender, EventArgs e)
        {
            int savings = int.Parse(savingsAccount.Text);
            int checking = int.Parse(checkAccount.Text);

            if (savings < 100 && checking < 50)
            {
                MessageBox.Show("Both Accounts are low");
            }
            else if (savings < 100 && checking > 50)
            {
                MessageBox.Show("Savings account is low");

            } else if (checking < 50)
            {
                MessageBox.Show("Checking account is low");

            } else
            {
                MessageBox.Show("Balance is looking good");
            }

        }
    }
}
