using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4_EvenNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            for (int i = 2, numberCount = 0; i <= 100; i += 2)
            {   
                lblNumbers.Text += (i + " ");
                numberCount++;
                if (numberCount % 10 == 0)
                {
                    lblNumbers.Text += ("\n");
                }
              
            }
        }
    }
}
