using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paul_Hayes_Skills_Test_Property
{
    public partial class Form1 : Form
    {
        // initialize variables to be used
        MyProperty_[] propertyArray = new MyProperty_[10];
        string propNumber;
        string suburb;
        int bedrooms;
        double rental;
        string status;

        public Form1()
        {
            InitializeComponent();
        }

        #region FormLoading
        private void Form1_Load(object sender, EventArgs e)
        {
            txtPropertyNumber.Focus();
            // load the array with the 4 initial values
            propertyArray[0] = new MyProperty_
            {
                PropertyNumber = "PET1",
                Suburb = "Petersham",
                Bedrooms = 1,
                RentalPrice = 160,
                Status = "New"
            };
            propertyArray[1] = new MyProperty_
            {
                PropertyNumber = "STA1",
                Suburb = "Stanmore",
                Bedrooms = 3,
                RentalPrice = 240,
                Status = "Renovated"
            };
            propertyArray[2] = new MyProperty_
            {
                PropertyNumber = "STA2",
                Suburb = "Stanmore",
                Bedrooms = 2,
                RentalPrice = 70,
                Status = "Old"
            };
            propertyArray[3] = new MyProperty_
            {
                PropertyNumber = "PET2",
                Suburb = "Petersham",
                Bedrooms = 2,
                RentalPrice = 190,
                Status = "Renovated"
            };
        }
        #endregion

        #region Buttons
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string msg = "";
            // simple for each loop to print out each non-null (to prevent errors) members of the array
            foreach (var property in propertyArray)
            {
                if (property != null)
                {
                    msg += property.PrintInfo();
                }
            }
            MessageBox.Show(msg);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // error check to make sure only ints or doubles were entered into the bedroom and rental boxes
            if (CheckForNumberEntered(txtBedrooms.Text) == false)
            {
                ErrorMessageBeds();
                return;
            }

            if (CheckForNumberEntered(txtPrice.Text) == false)
            {
                ErrorMessageRent();
                return;
            }

            // check to make sure something has been selected from the combo box and error message if not
            if (cmbStatus.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the property condition");
                return;
            }
            else
            {
                //extract the info from the boxes and load them into variables to add the property array
                propNumber = txtPropertyNumber.Text.ToUpper();
                suburb = txtSuburb.Text;
                bedrooms = int.Parse(txtBedrooms.Text);
                rental = double.Parse(txtPrice.Text);
                status = cmbStatus.SelectedItem.ToString();

                // error check to ensure all forms had been entered correctly and error message if not
                if (propNumber == "" || suburb == "" || bedrooms < 0 || rental < 0)
                {
                    ErrorMessageValues();
                    return;
                }

                // loop to check for the next empty space in the array and to add the property to that space
                for (int i = 0; i < propertyArray.Length; i++)
                {
                    if (propertyArray[i] == null)
                    {
                        propertyArray[i] = new MyProperty_(propNumber, suburb, bedrooms, rental, status);
                        break;
                    }
                    if (i == propertyArray.Length - 1)
                    {
                        MessageBox.Show("Array Full!");
                        return;
                    }
                }
                MessageBox.Show("Property Added");
                ClearTextBoxes();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // store variables for the property message and for the property number
            string msg = "";
            string propNumber = txtPropertyNumber.Text.ToUpper();

            // loop the array and search for the matching property to the property number
            for (int i = 0; i < propertyArray.Length; i++)
            {
                if (propertyArray[i].PropertyNumber == propNumber)
                {
                    msg += propertyArray[i].PrintInfo();
                    MessageBox.Show(msg);
                    break;
                }
                else
                {
                    MessageBox.Show("Property Not Found");
                    break;
                }
            }
        }
        private void btnAverageRent_Click(object sender, EventArgs e)
        {
            double avgRent = CalculateAverage();
            MessageBox.Show($"The Average Rent for all the properties is: ${avgRent}");
        }
        #endregion

        #region methods used
        /// <summary>
        /// function to check if a only a number has been entered into a text box
        /// </summary>
        /// <returns></returns>
        private bool CheckForNumberEntered(string text)
        {
            double check;
            bool result = Double.TryParse(text, out check);
            return result;
        }

        /// <summary>
        /// clear all text boxes for the next entry
        /// </summary>
        private void ClearTextBoxes()
        {
            txtBedrooms.Clear();
            txtPrice.Clear();
            txtPropertyNumber.Clear();
            txtSuburb.Clear();
            txtPropertyNumber.Focus();
        }

        /// <summary>
        /// method to calculate average rental price
        /// </summary>
        /// /// <returns></returns>
        private double CalculateAverage()
        {
            // set variables to store the total and to count the amount of items in the array          
            double totalRent = 0;
            int count = 0;
            foreach (var property in propertyArray)
            {
                if (property != null)
                {
                    totalRent += property.RentalPrice;
                    count++;
                }
            }
            return totalRent / count;
        }
        #endregion

        #region methods for error messages
        // Error messages for not entering numbers into bedrooms and rental prices
        private void ErrorMessageBeds()
        {
            MessageBox.Show("Please enter only numbers into the Bedrooms text box");
            txtBedrooms.Clear();
            txtBedrooms.Focus();
        }

        private void ErrorMessageRent()
        {
            MessageBox.Show("Please enter only numbers into the Rental Price text box");
            txtPrice.Clear();
            txtPrice.Focus();
        }

        private void ErrorMessageValues()
        {
            MessageBox.Show("Please fill out all the fields correctly");
            ClearTextBoxes();
            return;
        }
        #endregion
    }
}
