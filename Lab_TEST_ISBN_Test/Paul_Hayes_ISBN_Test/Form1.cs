using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paul_Hayes_ISBN_Test
{
    public partial class Form1 : Form
    {
        int digitSum;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // initialize array to hold the isbn number
            int[] isbnArray = new int[10];

            // string to get the number which I will convert to the array
            int isbnCheck;

            bool result = int.TryParse(txtIsbn.Text, out isbnCheck);

            // error checks to see if its the right length and only integers
            if (result == false || txtIsbn.TextLength != 10) 
            {
                MessageBox.Show("Invalid input. Please a 10 digit number only");
            }
            else
            {
                // iterate through the string and parse it to int and add to the isbn array
                //isbnNumber = txtIsbn.Text;
                char[] isbnNum = txtIsbn.Text.ToCharArray();

                for (int i = 0; i < 10; i++)
                {
                    isbnArray[i] = Convert.ToInt32(isbnNum[i]);
                }

                // loop to apply the multiples
                AddMultiples(isbnArray);
                
                // check if its a valid number and display message if it is
                CalculateValidIsbn(digitSum);
            }
            resetTextbox();
        }

       
        void resetTextbox()
        {
            txtIsbn.Clear();
            txtIsbn.Focus();
        }
        void CalculateValidIsbn(int x)
        {
            if (x % 11 == 0)
            {
                MessageBox.Show("That is a valid ISBN");
            }
            else
            {
                MessageBox.Show("That is a NOT a valid ISBN");
            }
            digitSum = 0;
        }

        private int AddMultiples(int[] arr)
        {
            int x =0;
            for (int i = 0, j = 10; i < 10; i++, j--)
            {
                x += (arr[i] * j);
            }
            return x;
        }
    }
}
