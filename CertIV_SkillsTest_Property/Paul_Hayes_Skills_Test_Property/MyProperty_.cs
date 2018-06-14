using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paul_Hayes_Skills_Test_Property
{
    public class MyProperty_
    {
        #region variables
        /// <summary>
        /// variables to hold details about the each property
        /// </summary>
        private string propertyNumber;
        private string suburb;
        private int bedrooms;
        private double rentalPrice;
        private string status;

        public string PropertyNumber
        {
            get
            {
                return propertyNumber;
            }

            set
            {
                propertyNumber = value;
            }
        }

        public string Suburb
        {
            get
            {
                return suburb;
            }

            set
            {
                suburb = value;
            }
        }

        public int Bedrooms
        {
            get
            {
                return bedrooms;
            }

            set
            {
                bedrooms = value;
            }
        }

        public double RentalPrice
        {
            get
            {
                return rentalPrice;
            }

            set
            {
                rentalPrice = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        #endregion

        #region constructors
        // constructors
        public MyProperty_()
        {

        }
        // constructor with parameters
        public MyProperty_(string propertyNumber, string suburb, int bedrooms, double rentalPrice, string status)
        {
            this.PropertyNumber = propertyNumber;
            this.Suburb = suburb;
            this.Bedrooms = bedrooms;
            this.RentalPrice = rentalPrice;
            this.Status = status;
        }
        #endregion

        #region method
        // method to print the property details
        public string PrintInfo()
        {
            string msg = "";
            msg += $"Property no:  {propertyNumber}, Suburb:  {suburb}, Bedrooms:  {bedrooms}, Rental Price:  {rentalPrice}, Status:  {status}\n\n";
            return msg;
        }
        #endregion
    }
}
