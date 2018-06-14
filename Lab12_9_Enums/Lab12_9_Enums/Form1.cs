using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab12_9_Enums
{
    public partial class Form1 : Form
    {
        MyStaff[] staffArray = new MyStaff[5];
        int arrayCount;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            arrayCount = 0;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (arrayCount < 5)
            {
                string title = cmbTitle.SelectedItem.ToString();
                staffArray[arrayCount] = new MyStaff(txtName.Text, title);
                arrayCount++;
            } else
            {
                MessageBox.Show("Array Full");
            }
          
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string msg = "";
            foreach (var staff in staffArray)

            {
                if (staff != null)
                {
                    msg += staff.ReturnInfo();
                }
               

            }
            MessageBox.Show(msg);
        }
    }
}
