using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_4_ticketnumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter the ticket number");
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int ticket = int.Parse(txtTicketNumber.Text);
            int ticketCheck = ticket / 10;
            int ticketRemainder = ticket % 10;
            //bool ticketTrue = false;

            if (ticketCheck % 7 == ticketRemainder)
            {
                MessageBox.Show("Your ticket is valid");
            }
            else
            {
                MessageBox.Show("Ticket Invalid");
            }

        }
    }
}
