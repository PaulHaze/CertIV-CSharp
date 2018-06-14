using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11_6_Rectangle
{
    public partial class Form1 : Form
    {
        
        double length;
        double width;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtWidth.Text);
            Rectangle rec = new Rectangle(length, width);
    
            string msg = rec.RectangleInfo();
            MessageBox.Show(msg);
        }

     
    }
}
