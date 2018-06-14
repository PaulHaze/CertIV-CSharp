using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab12_1_ABC
{
    public partial class Form1 : Form

    {
        Employee[] empArray = new Employee[2];
        Employee emp1 = new Employee();
        Employee emp2 = new Employee();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            emp1.EmployeeName = "Hazy";
            emp1.EmployeeAddress = "123 Fake street";

            emp2.EmployeeName = "Derrick";
            emp2.EmployeeAddress = "125 Fake street";

            empArray[0] = emp1;
            empArray[1] = emp2;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string msg = "Employee 1: \n";
            msg += empArray[0].ShowDetails();
            msg += "Employee 2: \n";
            msg += empArray[1].ShowDetails();
            MessageBox.Show(msg);
            return;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = txtEmpName.Text;
            string empAdd = txtEmpAddress.Text;
            string coName = txtCompanyName.Text;
            string coAdd = txtCompanyAddress.Text;
            int arrayIndex = int.Parse(txtEmpNumber.Text);
            arrayIndex--;


            if (CheckText(name))
            {
                empArray[arrayIndex].EmployeeName = name;
            }
            if (CheckText(empAdd))
            {
                empArray[arrayIndex].EmployeeAddress = empAdd;
            }
            if (CheckText(coName))
            {
                empArray[arrayIndex].CompanyName = coName;
            }
            if (CheckText(coAdd))
            {
                empArray[arrayIndex].CompanyAddress = coAdd;
            }

            return;
        }

        // functions

        public bool CheckText(string text)
        {
            if (String.IsNullOrEmpty(text))
            {
                return false;
            }
            else return true;
        }
    }
}
