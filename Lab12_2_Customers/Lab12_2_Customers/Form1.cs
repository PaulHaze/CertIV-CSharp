using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12_2_Customers
{
    public partial class Form1 : Form
        
    {
        Customer[] custArray = new Customer[5];

        public Form1()
        {
            InitializeComponent();
        }

        // return the customer information

        public string CustomerInfo()
        {
            string msg = "";
            return msg;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < custArray.Length; i++)
            {
                if (custArray[i] == null)
                {
                    Customer newCustomer = new Customer(txtCustomer.Text);
                    custArray[i] = newCustomer;
                    MessageBox.Show("Customer Added");
                    break;
                }
                if (i == custArray.Length - 1)
                {
                    MessageBox.Show("Array full");
                }
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string msg = "";
            foreach (var customer in custArray)
            {
                if (customer != null)
                {
                 
                    msg += customer.ReturnInfo();
                }
               
            }
            MessageBox.Show(msg);
        }
    }
}
