using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab11_2_Car
{
    public partial class Form1 : Form
    {
        Car[] carsArray = new Car[3];
        //Car car = new Car();

        public Form1()
        {
            InitializeComponent();
        }

        // function to add car
        public bool Add(Car car)
        {
            for (int i = 0; i < carsArray.Length; i++)
            {
                if (carsArray[i] == null)
                {
                    carsArray[i] = car;
                    return true;
                }
            }
            return false;
        }

    


        private void btnSave_Click(object sender, EventArgs e)
        {
            Car car = new Car
            {
                Make = txtMake.Text,
                Model = txtModel.Text,
                Price = txtPrice.Text
            };

            if (Add(car))
            {
                MessageBox.Show("Car Added");
            }
            else
            {
                MessageBox.Show("Car Array Full");
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string msg = "";
            foreach (var car in carsArray)
            {
                int i = 1;

                if (car != null)
                {
                    msg += $"Car {i}:\n";
                    msg += car.PrintInfo();
                    i++;
                }
               
            }
            MessageBox.Show(msg);
        }
    }
}
