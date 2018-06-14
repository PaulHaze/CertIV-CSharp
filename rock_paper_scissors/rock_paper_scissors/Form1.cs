using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rock_paper_scissors
{
    public partial class Form1 : Form
    {
        Random ranNumberGenerator = new Random();
        int randomNumber;
        string userGuess;
        string compGuess;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomNumber = ranNumberGenerator.Next(0, 3);
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            userGuess = txtUserGuess.Text;

            if (randomNumber == 1)
            {
                compGuess = "r";
            }
            else if (randomNumber == 2)
            {
                compGuess = "p";
            }
            else compGuess = "s";

            string userChoice = convertBack(userGuess);
            string compChoice = convertBack(compGuess);

            string msg = ($"Computer chose: {compChoice} \nYou chose: {userChoice} \n");
            lblResult.Text = msg;

            int result = checkOutcome(userGuess, compGuess);
            if (result == 3)
            {
               msg += "Its a draw";
                
               
            } else if (result == 1)
            {
                msg += "You Lost!";
                randomNumber = ranNumberGenerator.Next(0, 3);
                lblResult.Text = "";
            } else if (result == 2)
            {
                msg += "You won";
                randomNumber = ranNumberGenerator.Next(0, 3);
                lblResult.Text = "";
            }

            txtUserGuess.Text = msg;

            


        }
        private int checkOutcome(string x, string y)
        {
            int result;
            if (x == y)
            {
                result = 3;
            }   
            else if ((x == "r" && y == "s") || (x == "s" && y == "p") || (x == "p" && y == "r"))
            {
                result = 2;
            }
            else
            {
                result = 1;
            }    
            return result;  
        }

        private string convertBack(string x)
        {
            string choice;
            if (x == "r")
            {
                choice = "Rock";
            } else if (x == "p")
            {
                choice = "Paper";
            }
            else
            {
                choice = "Scissors";
            }
            return choice;
        }
    }
}
