using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12_6_CasualEmployee
{
    public class CasualEmployee
    {
        private int employeeId;
        private string employeeName;
        private double payRate;

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public double PayRate { get => payRate; set => payRate = value; }

        // methods

        public double ReturnWage(int hours)
        {
            return payRate * hours;
        }

            




    }
