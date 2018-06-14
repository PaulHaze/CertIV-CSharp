using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_6_MovieTicket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int age = int.Parse(txtAge.Text);
            var movieRating = txtMovie.Text;

            if (age < 13 || (age >= 65 && movieRating == "g"))
            {
                MessageBox.Show("You are eligible for a discount");
            } else
            {
                MessageBox.Show("Sorry, the ticket is full price");
            }
        }
    }
}
