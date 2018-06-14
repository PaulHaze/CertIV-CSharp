using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_4_TwoNumbers
{
    public partial class Form1 : Form
    {
        int numOne;
        int numTwo;

        public Form1()
        {
            InitializeComponent();
        }

        void Sum(int x, int y)
        {
            int result = x + y;
            MessageBox.Show($"{x} + {y} = {result}");
        }

        void Difference(int x, int y)
        {
            int difference = 0;
            if (x > y)
            {
                difference = x - y;
            } else
            {
                difference = y - x;
            }
            MessageBox.Show($"The difference between {x} and {y} is: {difference}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numOne = int.Parse(txtNumOne.Text);
            numTwo = int.Parse(txtNumTwo.Text);
            Sum(numOne, numTwo);
            Difference(numOne, numTwo);
            txtNumOne.Clear();
            txtNumTwo.Clear();
        }
    }
}
