using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_1_SumOfCNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numChoice = int.Parse(txtNumberChoice.Text);
            int total = 0;
            int count = 1;
            while (count <= numChoice)
            {
                total += count;
                count++;
            }
            MessageBox.Show($"The total sum of consecutive numbers is {total}");
        }
    }
}
