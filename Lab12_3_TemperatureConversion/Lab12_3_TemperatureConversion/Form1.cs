using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12_3_TemperatureConversion
{
    public partial class Form1 : Form

    {
        TemperatureConversion temp = new TemperatureConversion();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (CheckBox(txtCelsius.Text))
            {
                double farenheit = TemperatureConversion.ConvertToFarenheit(txtCelsius.Text);
                txtFarenheit.Text = $"{farenheit}";

            }
        }
        private void btnConvertFarenheit_Click(object sender, EventArgs e)
        {
            if (CheckBox(txtFarenheit.Text))
            {
                double celsius = TemperatureConversion.ConvertToCelsius(txtFarenheit.Text);
                txtCelsius.Text = $"{celsius}";

            }

        }

        // function to check if box is empty

        bool CheckBox(string box)
        {
            if (String.IsNullOrEmpty(box))
            {
                return false;
            }
            else return true;
        }

    }
}
