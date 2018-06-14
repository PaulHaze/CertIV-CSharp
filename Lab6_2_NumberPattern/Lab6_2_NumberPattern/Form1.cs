using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6_2_NumberPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int userNumber = int.Parse(txtUserNumber.Text);
            int count = 1;
            var msg = "";

            for (int i = 1; i < userNumber; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    msg += $"{count}";
                    count++;
                    if (count == userNumber + 1)
                    {
                        lblTriangle.Text = msg;
                        return;
                    }
                }
                msg += "\n";
            }
        }
       
    }
}
