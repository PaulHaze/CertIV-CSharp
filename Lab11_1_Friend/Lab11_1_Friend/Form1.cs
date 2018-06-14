using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11_1_Friend
{
    public partial class Form1 : Form
    {
        Friend friend = new Friend();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddFriend_Click(object sender, EventArgs e)
        {
            friend.Name = txtName.Text;
            friend.Address = txtAddress.Text;
            friend.Phone = txtPhone.Text;

            string msg = $"Name: {friend.Name}\n";
            msg += $"Address: {friend.Address}\n";
            msg += $"Phone: {friend.Phone}\n";

            MessageBox.Show(msg);
        }
    }
}
