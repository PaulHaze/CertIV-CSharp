using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_1_ArrayDemo
{
    public partial class Form1 : Form
    {

        double[] myDoubleArray = new double[4];
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnterNumber_Click(object sender, EventArgs e)
        {
            if (count == 4)
            {
                for (int i = 0; i < myDoubleArray.Length; i++)
                {
                    MessageBox.Show($"Double Array index {i} holds {myDoubleArray[i]}");                               
                }
                count = 0;
                txtNumber.Clear();
                txtNumber.Focus();
                return;              
            }
            else
            {
                myDoubleArray[count] = double.Parse(txtNumber.Text);
                txtNumber.Clear();
                txtNumber.Focus();   
                count++;
            }

        }
    }
}
