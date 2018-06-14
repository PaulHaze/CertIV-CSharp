using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCaclulate_Click(object sender, EventArgs e)
        {
            string lengthString = lengthNumber.Text;
            string widthString = widthNumber.Text;

            int length = int.Parse(lengthString);
            int width = int.Parse(widthString);

            int result = length * width;

            string msg = "Result is: \n";
            msg += result.ToString() + " cm";

            MessageBox.Show(msg);
        }

        private void btnCalculate2_Click(object sender, EventArgs e)
        {
            double length = double.Parse(lengthNumber.Text);
            double width = double.Parse(widthNumber.Text);
            double result = length * width;

            string msg = "Result is: \n";
            msg += result.ToString() + " cm";

            MessageBox.Show(msg);


        }

        private void btnCalculate3_Click(object sender, EventArgs e)
        {
           
            double length;
            double width;

            bool lengthSuccess = double.TryParse(lengthNumber.Text, out length);
            bool widthSuccess = double.TryParse(widthNumber.Text, out width);

            if (lengthSuccess && widthSuccess)
            {
                double result = length * width;

                string msg = "Result is: \n";
                msg += result.ToString() + " cm";

                MessageBox.Show(msg);
            } else
            {
                MessageBox.Show("Renter the correct numbers");
            }
        


            
        }
    }
}
