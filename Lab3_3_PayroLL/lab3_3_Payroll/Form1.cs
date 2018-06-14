using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_3_Payroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("PLease enter your hourly pay rate and hours worked");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            double hourlyPay = double.Parse(rate.Text);
            double hoursWorked = double.Parse(hours.Text);
            double grossPay = hourlyPay * hoursWorked;
            lblGrossPaid.Text += "$" + grossPay;

            double tax = (grossPay / 100) * 30;
            double netPay = grossPay - tax;
            lblNetPaid.Text += "$" + netPay;
            
        }
    }
}
