using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_3_Furniture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string wood = woodEntered.Text;

            if (wood == "pine")
            {
                lblWoodChosen.Text = "Pine";
                lblCostTable.Text = "$100";

            } else if (wood == "oak")
            {
                lblWoodChosen.Text = "Oak";
                lblCostTable.Text = "$285";
            } else
            {
                MessageBox.Show("Please enter a valid selection");
                lblWoodChosen.Text = "";
                lblCostTable.Text = "";
                
            }

        }
    }
}
