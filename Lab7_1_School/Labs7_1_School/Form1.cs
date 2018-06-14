using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labs7_1_School
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("The following is the name and address of my school:");
            NameAndAddress();
        }
        void NameAndAddress()
        {
            MessageBox.Show("Petersham Tafe\n 27 Crystal St,\n Sydney, \nNSW");
        }
    }


}
