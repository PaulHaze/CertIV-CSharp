using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_1_For_Loop_Integers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            var total = 0;
            for (int i = 0; i < 21; i++)
            {
                total += i;
            }
            MessageBox.Show("Sum total of 1 to 20 is " + total);
        }
    }
}
