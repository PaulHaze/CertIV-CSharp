using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_1_Vowel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var letter = txtLetter.Text;
            switch (letter)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    MessageBox.Show("Your letter is a vowel");
                    txtLetter.Clear();
                    break;

                default:
                    MessageBox.Show("Your letter is not a vowel");
                    txtLetter.Clear();
                    break;
            }

        }
    }
}
