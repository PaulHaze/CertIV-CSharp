using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_2_Basic_Maths
{
    public partial class Form1 : Form
    {
        int userNumber = 0;

        public Form1()
        {
            InitializeComponent();
        }

        void DisplayIt(int x)
        {
            MessageBox.Show($"The number you entered was: {x}");
        }

        void DisplayItTimesTwo(int x)
        {
            MessageBox.Show($"Your number multiplied by two is: {x * 2}");
        }
        void DisplayItPlusOneHundred (int x)
        {
            MessageBox.Show($"Your number plus 100 is: {x + 100}");
        }

        void Reset()
        {
            MessageBox.Show("Please enter another number");
            txtUserNumber.Clear();
            txtUserNumber.Focus();
            userNumber = 0;
        }

        private void btnStartMethods_Click(object sender, EventArgs e)
        {
            userNumber = int.Parse(txtUserNumber.Text);
            DisplayIt(userNumber);
            DisplayItTimesTwo(userNumber);
            DisplayItPlusOneHundred(userNumber);
            Reset();
        }
    }
}
