using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_5_Star_pattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var msg = "";

            for (int i = 1; i < 6; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    msg += "*";
                }
                msg += "\n";
            }

            for (int i = 5; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    msg += "*";
                }
                msg += "\n";
            }
            lblStars.Text = msg;
        }
    }
}
