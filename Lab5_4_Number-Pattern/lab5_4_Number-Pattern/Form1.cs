using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_4_Number_Pattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            var msg = "";
            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    msg += $"{i}";
                }
                msg += "\n";
            }   
            lblOutput.Text = msg;
        }     
    }
}
