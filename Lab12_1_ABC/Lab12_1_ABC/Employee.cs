using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_1_ABC
{
    public class Employee
    {
        // fields

        // th right way to do it
        // public static string companyName = "ABC"
            
        private string employeeName;
        private string employeeAddress;
        private string companyName;
        private string companyAddress;

        

        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string EmployeeAddress { get => employeeAddress; set => employeeAddress = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string CompanyAddress { get => companyAddress; set => companyAddress = value; }


        // set the static variables
        //public static string companyName = "ABC";
        //public static string companyAddress = "123 Sesame Street";
        public Employee()
        {
            CompanyName = "ABC";
            CompanyAddress = "123 Sesame St";
        }


        // return employees details
        public string ShowDetails()
        {
            string msg = "";
            msg += $"Name: {employeeName}\n";
            msg += $"Address: {employeeAddress}\n";
            msg += $"Company Name: {CompanyName}\n";
            msg += $"Company Address: {CompanyAddress}\n";
            return msg;
        }
    }
}
