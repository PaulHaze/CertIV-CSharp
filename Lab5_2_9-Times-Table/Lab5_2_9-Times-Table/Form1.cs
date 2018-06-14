using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_2_9_Times_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            int number = int.Parse(txtUserNumber.Text);

            if (number < 1 || number > 9) 
            {
                MessageBox.Show("PLease enter a valid number");
                txtUserNumber.Clear(); 
            } else
            { 
                var output = "";
                for (int i = 1; i < 10; i++)
                {
                    output += $"{number} * {i} = {number * i}\n";
                }
            lblResult.Text = output;
            }
        }

    }
    
}
