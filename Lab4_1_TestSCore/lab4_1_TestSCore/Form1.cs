using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_1_TestSCore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void checkScore_Click(object sender, EventArgs e)
        {
            int studentScore = int.Parse(scoreEntered.Text);
            if (studentScore > 50)
            {
                MessageBox.Show("Congratulations you have passed");

            }
            else
            {

                MessageBox.Show("Sorry, you have failed");
            }    
                
        }

        
    }
}
