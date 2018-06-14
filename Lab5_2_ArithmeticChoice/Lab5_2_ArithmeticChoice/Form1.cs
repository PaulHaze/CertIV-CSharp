using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_2_ArithmeticChoice
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var msg = "";
            double total;
            double numOne = Double.Parse(txtNumberOne.Text);
            double numTwo = Double.Parse(txtNumberTwo.Text);
            var operation = txtOperation.Text;

            switch (operation)
            {
                case "a":
                case "A":
                case "+":
                    total = numOne + numTwo;
                    msg += $"{numOne} plus {numTwo} = {total}\n";
                    break;

                case "S":
                case "s":
                case "-":
                    total = numOne - numTwo;
                    msg += $"{numOne} minus {numTwo} = {total}\n";
                    break;

                case "D":
                case "d":
                case "/":
                    if (numOne == 0 || numTwo == 0)
                    {
                        MessageBox.Show("Can't divide by zero");
                        break;
                        //continue;
                    }
                    total = numOne / numTwo;
                    msg += $"{numOne} divided by {numTwo} = {total}\n";
                    break;

                case "M":
                case "m":
                case "*":
                    total = numOne * numTwo;
                    msg += $"{numOne} multiplied by {numTwo} = {total}\n";
                    break;
            }
            MessageBox.Show(msg);
            txtNumberOne.Clear();
            txtNumberTwo.Clear();
            txtOperation.Clear();
            txtNumberOne.Focus();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNumberOne.Focus();
        }
    }
}
