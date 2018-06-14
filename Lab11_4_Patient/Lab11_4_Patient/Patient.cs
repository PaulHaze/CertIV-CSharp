using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_4_Patient
{
    public class Patient
    {
        //fields
        private string name;
        private string height;
        private string weight;
        private string age;
        private int contact;

        public string Name { get => name; set => name = value; }
        public string Height { get => height; set => height = value; }
        public string Weight { get => weight; set => weight = value; }
        public string Age { get => age; set => age = value; }
        public int Contact { get => contact; set => contact = value; }

        // constructors
        public Patient()
        {

        }

        public Patient(string name, int contact)
        {
            this.Name = name;
            this.Contact = contact;
        }

        public Patient(string name, string height, string weight, int contact)
        {
            this.Name = name;
            this.Contact = contact;
            this.Height = height;
            this.weight = weight;

        }


    }
}
