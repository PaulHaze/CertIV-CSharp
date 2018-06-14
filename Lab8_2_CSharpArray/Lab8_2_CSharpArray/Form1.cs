using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8_2_CSharpArray
{
    public partial class Form1 : Form
    {
        string[] reasonsForC = new string[] { "01. Too early to say why",
                                              "02. Really, we have to list 10",
                                              "03. Ten seems a bit excessive",
                                              "04. I like C cos its like Java",
                                              "05. Cos its the 3rd letter of the alphabet",
                                              "06. Cos it rhymes with see",
                                              "07. It also rhymes with sea",
                                              "08. This is reason 8",
                                              "09. THis is reason 9",
                                              "10. I like c cos this is reason 10 and the end of this list"};
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTellMe_Click(object sender, EventArgs e)
        {
            int choice = int.Parse(txtUserNumber.Text);
            MessageBox.Show($"You like C# because: {reasonsForC[choice - 1]}");
        }
    }
}
