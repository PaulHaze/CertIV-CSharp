using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Employee
    {
        #region Attributes

        public int EmpID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public string Email { get; set; }
        public string DateOfBirth { get; set; }
        public string Phone { get; set; }

        #endregion

        #region Constructors

        public Employee()
        {

        }

        public Employee(string fname, string lname, string email, string dob, string phone)
        {
            FirstName = fname;
            LastName = lname;
            Email = email;
            DateOfBirth = dob;
            Phone = phone;
        }

        public Employee(int empid, string fname, string lname, string email, string dob, string phone)
        {
            EmpID = empid;
            FirstName = fname;
            LastName = lname;
            Email = email;
            DateOfBirth = dob;
            Phone = phone;
        }

        #endregion
    }
}
