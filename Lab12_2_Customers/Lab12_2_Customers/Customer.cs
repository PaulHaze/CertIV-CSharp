using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_2_Customers
{
    public class Customer
    {
        // set the variables
        private int customerId;
        private string customerName;

        private static int lastId = 0;

        public string name;

        public int CustomerId { get => customerId; set => customerId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }

        // constructors

        public Customer()
        {

        }

        public Customer(string customerName)
        {
            this.CustomerName = customerName;
            lastId++;
            CustomerId = lastId;
        }

        // methods

        // method to return an int of the last id

        public static int ReturnLastID()
        {
            return lastId;
        }

        public string ReturnInfo()
        {
            string msg = "";
            msg += $"Customer Name: {customerName}\n";
            msg += $"Customer Id: {customerId}\n";
            return msg;

        }


    }
}
