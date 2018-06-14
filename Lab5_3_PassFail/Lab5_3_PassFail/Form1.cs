using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_3_PassFail
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var testScore = int.Parse(txtScore.Text);
            if (testScore >= 50)
            {
                MessageBox.Show("You have passed");
            }
            else
                MessageBox.Show("You have failed");

            txtScore.Clear();
            txtScore.Focus();
        }
    }
}
