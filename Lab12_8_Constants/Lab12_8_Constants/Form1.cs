using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12_8_Constants
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertMetres_Click(object sender, EventArgs e)
        {
            
            double km = double.Parse(txtNumberEntered.Text);
            ConvertFromKm newKm = new ConvertFromKm(km);
            double converted = newKm.ConvertKiloToMeters();
            txtConversion.Text = $"{converted}";
            
        }

        private void btnConvertCm_Click(object sender, EventArgs e)
        {
            double km = double.Parse(txtNumberEntered.Text);
            ConvertFromKm newKm = new ConvertFromKm(km);
            double converted = newKm.ConvertKiloToCM();
            txtConversion.Text = $"{converted}";
        }
    }
}
