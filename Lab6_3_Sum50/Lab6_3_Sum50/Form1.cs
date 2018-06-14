using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_3_Sum50
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var total = 0;
            for (int i = 1; i < 51; i++)
            {
                total += i;
            }
            MessageBox.Show($"The sum total of all integers from 1 -> 50 is {total}");
        } 
    }
}
