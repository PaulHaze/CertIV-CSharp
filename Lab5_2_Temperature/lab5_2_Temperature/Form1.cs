using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_2_Temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertTemp_Click(object sender, EventArgs e)
        {
            var output = "";
            for (double i = -5; i <= 10; i+= 0.5)
            {
                output += $"{i} degrees centigrade is {ConvertTemp(i)} degrees farenheit\n";
            }
            lblTemperatures.Text = output;
        }

        

        private double ConvertTemp(double x)
        {
            return ((9 * x) / 5) + 32;
        }
    }
}
