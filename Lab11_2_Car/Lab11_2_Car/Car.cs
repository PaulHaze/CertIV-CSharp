using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_2_Car
{
    public class Car
    {
        // set fields
        private string make;
        private string model;
        private string price;

        public string Make { get => make; set => make = value; }
        public string Model { get => model; set => model = value; }
        public string Price { get => price; set => price = value; }

        // constructors


        // methods

        public string PrintInfo()
        {
            string msg = "";
            msg += $"Make: {Make}\n";
            msg += $"Model: {Model}\n";
            msg += $"Price: {Price}\n\n";
            return msg;
            
        }


    }
}
