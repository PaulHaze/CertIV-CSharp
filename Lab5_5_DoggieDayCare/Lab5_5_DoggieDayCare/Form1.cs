using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_5_DoggieDayCare
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();     
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int costOfStay;
            int dogWeight = int.Parse(txtWeight.Text);
            int days = int.Parse(txtDays.Text);
            int dailyRate = DailyRateCalc(dogWeight, days);

            while (dogWeight == 0 || days == 0)
            {
                txtDays.Clear();
                txtWeight.Clear();
                MessageBox.Show("Incorrect Entry");
                return;
            }
            
            if (days < 11)
            {
                costOfStay = TotalCostShort(dogWeight, days);
                PrintMessage(dailyRate, costOfStay);
            } else
            {
                costOfStay = TotalCostLong(dogWeight, days);
                PrintMessage(dailyRate, costOfStay);
            }
            txtDays.Clear();
            txtWeight.Clear();
            txtWeight.Focus();
        }

        private void PrintMessage(int a, int b)
        {
            MessageBox.Show($"Your daily rate is ${a} and your total stay is ${b}");
        }

        private int TotalCostShort(int x, int y)
        {
            if (x < 3)
            {
                return (15 * y);
            } else if (x < 10)
            {
                return (20 * y);
            } else
            {
                return (25 * y);
            }
        }

        
        private int TotalCostLong(int x, int y)
        {
            if (x < 3)
            {
                return (12 * y);
            }
            else if (x < 10)
            {
                return (17 * y);
            }
            else
            {
                return (22 * y);
            }
        }

        private int DailyRateCalc(int x, int y)
        {
            int rate = 0;
            if (y < 11)
            {
                if (x < 3)
                {
                    rate = 15;
                }
                else if (x <= 10)
                {
                    rate = 20;
                }
                else
                {
                    rate = 25;
                }
            }

            if (y >= 11)
            {
                if (x < 3)
                {
                    rate = 12;
                }
                else if (x <= 10)
                {
                    rate = 17;
                }
                else
                {
                    rate = 22;
                } 
            }
            return rate;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtWeight.Focus();
        }
    }
}
