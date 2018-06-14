using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_4_IQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int iq = int.Parse(txtIqEntered.Text);
            if (iq < 0 || iq > 200)
            {
                MessageBox.Show("Number entered was invalid");
                txtIqEntered.Clear();
                txtIqEntered.Focus();

            } else if (iq > 0 && iq < 100)
            {
                MessageBox.Show("Iq is below average");
                
            } else if (iq == 100)
            {
                MessageBox.Show("Iq is average");

            } else 
            {
                MessageBox.Show("Iq is above average");
            }
            txtIqEntered.Clear();
        }
    }
}
