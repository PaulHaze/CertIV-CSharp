using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_3_Eggs
{
    public partial class Form1 : Form
    {
        int eggsEntered = 0;

        public Form1()
        {
            InitializeComponent();
        }

        void NumOfEggs(int x)
        {
            MessageBox.Show($"You have {x / 12} dozens \n With {x % 12} eggs remaining");
            txtEggs.Clear();
            txtEggs.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            eggsEntered = int.Parse(txtEggs.Text);
            NumOfEggs(eggsEntered);
        }
    }
}
