using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paul_Hayes_Trial_Skill_Exam
{
    public partial class Form1 : Form
    {
        // initialize an array of seat numbers
        int[] seatsAvailable = new int[40];
        double totalSpend = 0;
     
    public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int seatTicket;
            bool result = Int32.TryParse(txtTicket.Text, out seatTicket);
            if (result == false)
            {
                ErrorMessage();
            } else
            { 
                seatTicket = int.Parse(txtTicket.Text); // extract the seat number chosen

                // check to see if the number entered is in range
                if (seatTicket < 1 || seatTicket > 40)
                {
                    ErrorMessage();
                    return;            
                }

                // loop through and see if it is available. If the Array index is != 0, 
                // then the seat is available and the index is replaced by 0
                if (seatsAvailable[seatTicket-1] != 0)
                {
                    MessageBox.Show("That seat is available. Please pay $7.50\n Add another seat, see your total spend or check more availabilty");
                    seatsAvailable[seatTicket - 1] = 0;
                    totalSpend += 7.5;
                    txtTicket.Clear();
                    txtTicket.Focus();
                } else
                {
                MessageBox.Show("Sorry the seat has been taken, please try another");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // create a for loop to fill the array with ints from 1 to 40
            for (int i = 0, j = 1; i < 40; i++, j++)
            {
                seatsAvailable[i] = j;
            }
        }

        private void btnTotalSpend_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Your total spend so far is: ${totalSpend}");
        }

        private void btnSeatsAvailable_Click(object sender, EventArgs e)
        {
            string msg = "Seats available: \n";
            int count = 0;
            for (int i = 0; i < 40; i++)
            {
                if (seatsAvailable[i] != 0)
                {
                    msg += (i + 1) + " ";
                    count++;
                }
                if (count % 10 == 0)
                {
                    msg += "\n";
                }
            }
            MessageBox.Show(msg);
        }
        private void ErrorMessage()
        {
            MessageBox.Show("Your choice is outside of range. \n Please choose between 1 and 40");
            txtTicket.Clear();
            txtTicket.Focus();
            return;
        }
    }
}
