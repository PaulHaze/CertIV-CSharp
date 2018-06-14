using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_6_FinalPrice
{
    public partial class Form1 : Form
    {
        double price;
        double salesCommission;
        double custDiscount;
        string msg = "";

        public Form1()
        {
            InitializeComponent();
        }

        double CalcPrice(double price, double com, double disc)
        {
            msg = $"Product price is: ${price}\n";

            // divide the numbers entered to get a percentage
            double commissionRate = com / 100;
            double customerDiscount = disc / 100;

            // calculate the total of the sales commision and add it on
            double interPrice = Math.Round(price + (price * commissionRate), 2);
            
            // Display the commission rate and price
            msg += $"Sales commission is {com}%\n";
            msg += $"Price with commission is ${interPrice}\n";
           
            // calculate the total customer discount and subtract it off
            msg += $"The customer discount is {disc}%\n";
            double finalPrice = interPrice - (interPrice * customerDiscount);
            msg += $"The final price is: ${Math.Round(finalPrice, 2)}";
            return Math.Round(finalPrice, 2);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            price = double.Parse(txtPrice.Text);
            salesCommission = double.Parse(txtSalesCommission.Text);
            custDiscount = double.Parse(txtDiscount.Text);
            CalcPrice(price, salesCommission, custDiscount);
            MessageBox.Show(msg);

            // reset the form
            txtPrice.Clear();
            txtDiscount.Clear();
            txtSalesCommission.Clear();
            txtPrice.Focus();
        }
    }
}
