using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Model;
using Controller;


namespace ETS
{
    public partial class EmpTracker : Form
    {
        // set up a controllers to be used throughout the class
        private readonly EmployeeController _empController = new EmployeeController();
        private readonly HoursController _hoursController = new HoursController();
        private readonly List<Employee> empList = new List<Employee>();
        Result<Employee> allEmployees = new Result<Employee>();

        #region Initializing methods
        public EmpTracker()
        {
            // load up inital data values such as hours and employee info into the form
            InitializeComponent();
            LoadEmployeeData();
            LoadEmployeeHours();
        }

        private void EmpTracker_Load(object sender, EventArgs e)
        {
            allEmployees = _empController.GetAll();

            // separate the employees into their own list to use later
            foreach (var employee in allEmployees.Data)
            {
                empList.Add(employee);
            }
        }

        /// <summary>
        /// Update the home screen with the current database of employees
        /// </summary>
        public void LoadEmployeeData()
        {

            Result<Employee> data = _empController.GetAll();
            if (data.Status == ResultsEnum.Success)
            {
                // populate the employees listbox on the 'home' tab
                lstbxHomeEmployees.DataSource = data.Data;
                lstbxHomeEmployees.DisplayMember = "FullName";

                // populate the comboboxes on the 'manage hours' tab
                cmbHoursEmployeeId.DataSource = data.Data;
                cmbHoursEmployeeId.DisplayMember = "EmpId";
                cmbHoursEmployeeName.DataSource = data.Data;
                cmbHoursEmployeeName.DisplayMember = "FullName";
            }
            else
            {
                MessageBox.Show(@"Cannot get employees");
            }

        }

        /// <summary>
        /// update the hours page from the database
        /// </summary>
        public void LoadEmployeeHours()
        {
            Result<EmployeeHours> hours = _hoursController.GetAllHours();

            if (hours.Status == ResultsEnum.Success)
            {
                // create a new list of all the work hours sorted by date
                List<EmployeeHours> sortedHours = hours.Data.OrderBy(h => h.WorkDate).ToList();

                // populate the three listboxes on the 'manage hours' tab
                lstbxHoursEmpID.DataSource = sortedHours;
                lstbxHoursEmpID.DisplayMember = "EmpID";
                lstbxHoursDaysWorked.DataSource = sortedHours;
                lstbxHoursDaysWorked.DisplayMember = "WorkDate";
                lstbxHoursWorked.DataSource = sortedHours;
                lstbxHoursWorked.DisplayMember = "Hours";
            }
            else
            {
                MessageBox.Show(@"Cannot get employee hours");
            }
        }

        #endregion

        #region HOME tab

        /// <summary>
        /// update employee info when one is selected in the list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstbxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateDisplayOnIndexChange();
        }
        #endregion

        #region HOME Methods

        /// <summary>
        /// updates the display on the home page when a new employee is selected
        /// </summary>
        private void UpdateDisplayOnIndexChange()
        {
            Employee selectedEmployee = (Employee)lstbxHomeEmployees.SelectedItem;
            UpdateEmployeeDetails(selectedEmployee);

            // get the employees Id and updates the hours accordingly
            int empId = int.Parse(selectedEmployee.EmpID.ToString());
            UpdateSelectedEmployeeWorkHours(empId);
        }

        /// <summary>
        /// updates the labels in the home tab with the selected
        /// Employee's details from the listbox
        /// </summary>
        /// <param name="emp"></param>
        private void UpdateEmployeeDetails(Employee emp)
        {
            lblHomeId.Text = emp.EmpID.ToString();
            lblHomeFirstName.Text = emp.FirstName;
            lblHomeLastName.Text = emp.LastName;
            lblHomeEmail.Text = emp.Email;
            lblHomeDateOfBirth.Text = RemoveTimeFromBirthDate(emp.DateOfBirth);
            lblHomePhone.Text = emp.Phone;
        }

        /// <summary>
        /// updates the work hours to show the selected employees hours
        /// </summary>
        /// <param name="empId"></param>
        private void UpdateSelectedEmployeeWorkHours(int empId)
        {
            Result<EmployeeHours> selectedHours = _hoursController.GetHoursById(empId);

            List<EmployeeHours> sortedHours = selectedHours.Data.OrderBy(h => h.WorkDate).ToList();
            lstbxHomeDate.DataSource = sortedHours;
            lstbxHomeDate.DisplayMember = "WorkDate";
            lstbxHomeHours.DataSource = sortedHours;
            lstbxHomeHours.DisplayMember = "Hours";
            lblHomeTotalHours.Text = CountTotalHours(sortedHours);
        }

        /// <summary>
        /// add up the total hours worked by the selected employee
        /// </summary>
        /// <param name="workHours"></param>
        /// <returns></returns>
        private string CountTotalHours(List<EmployeeHours> workHours)
        {
            int count = 0;
            foreach (var day in workHours)
            {
                count += day.Hours;
            }
            return count.ToString();
        }
        #endregion

        #region ADD/UPDATE tab buttons

        /// <summary>
        /// Method that adds an employee to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            ClearStatusText(); // clears whatever is in the status message bar 
            AddNewEmployee();
        }

        /// <summary>
        /// updates an employee based on the ID selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ClearStatusText();
            UpdateEmployee();
        }

        /// <summary>
        /// clears all the boxes and status messages
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearStatusText();
            ClearTextFields();
        }

        /// <summary>
        /// find an employee based on their ID number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindById_Click(object sender, EventArgs e)
        {
            ClearStatusText();

            if (IsValidIdNumber())
            {
                int id = int.Parse(txtAddId.Text);
                SearchById(id);

                CheckStatusForExtraButtons(); // makes the delete button appear if it returns a record
            }
        }

        /// <summary>
        /// removes an employee from the database based on their ID number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClearStatusText();

            if (IsValidIdNumber())
            {
                int id = int.Parse(txtAddId.Text);
                DeleteEmployeeById(id);
            }
        }

        /// <summary>
        /// move to 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecreaseId_Click(object sender, EventArgs e)
        {
            // if the id string is empty then the buttons start working down from the end of the list
            if (String.IsNullOrEmpty(txtAddId.Text))
            {
                SearchById(empList[empList.Count - 1].EmpID);
            }

            int empId = int.Parse(txtAddId.Text);
            int index = empList.FindIndex(x => x.EmpID == empId);

            // if pushing down takes us out of range then do nothing
            if (index - 1 < 0)
            {
                return;
            }

            // return an employee that is one below the one currently displayed
            SearchById(empList[index - 1].EmpID);
        }

        /// <summary>
        /// cycle upwards though all the employees
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIncreaseId_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddId.Text))
            {
                // if the id string is empty then the inc button will start working up from the beginning of the list
                SearchById(empList[0].EmpID);
            }

            var empId = int.Parse(txtAddId.Text);
            var index = empList.FindIndex(x => x.EmpID == empId);

            // if pushing up takes us out of range then do nothing
            if (index + 1 > empList.Count - 1)
            {
                return;
            }
            // return an employee that is one above the one currently displayed
            SearchById(empList[index + 1].EmpID);
        }

        #endregion

        #region ADD/UPDATE Methods

        /// <summary>
        /// Adds a new employee to the database
        /// </summary>
        private void AddNewEmployee()
        {
            if (!CheckId()) // returns if Id isnt blank with error message
            {
                return;
            }

            if (CheckTextBoxes()) // boolean to check that all the text fields are valid
            {
                // create a new employee object
                var emp = new Employee(txtAddFirstName.Text,
                                        txtAddLastName.Text,
                                        txtAddEmail.Text,
                                        dateTimeAddEmployee.Text,
                                        txtAddPhone.Text);

                // try and add the employee and check the result
                lblStatus.Text = AddEmployeeResult(emp);
            }
        }

        /// <summary>
        /// Adds the employees details and returns a string with the result
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        private string AddEmployeeResult(Employee emp)
        {
            ResultsEnum result = _empController.Add(emp);
            if (result == ResultsEnum.Success)
            {
                LoadEmployeeData(); // update the home page with the new data
                return @"Employee details added";
            }
            return @"Employee was not added, check the fields and try again";
        }

        /// <summary>
        /// Search for an employee via the ID entered into the Id textbox
        /// </summary>
        /// <param name="id"></param>
        private void SearchById(int id)
        {
            ResultFind foundEmp = _empController.FindEmployeeById(id);
            if (foundEmp.Status == ResultsEnum.Fail)
            {
                lblStatus.Text = @"Employee not found, try another ID";
                ClearTextFields();
                return;
            }

            // load up the text fields if the search was successful
            txtAddId.Text = foundEmp.Employee.EmpID.ToString();
            txtAddFirstName.Text = foundEmp.Employee.FirstName;
            txtAddLastName.Text = foundEmp.Employee.LastName;
            dateTimeAddEmployee.Text = RemoveTimeFromBirthDate(foundEmp.Employee.DateOfBirth);
            txtAddPhone.Text = foundEmp.Employee.Phone;
            txtAddEmail.Text = foundEmp.Employee.Email;
        }

        /// <summary>
        /// Update employee details depending on the ID number
        /// </summary>
        private void UpdateEmployee()
        {
            if (Validation.IsEmptyString(txtAddId.Text))
            {
                ErrorMessage(txtAddId, lblStatus, "ID has to be a valid number");
                return;
            }

            if (CheckTextBoxes())
            {
                // create a new employee object that will be updated
                var emp = new Employee(int.Parse(txtAddId.Text),
                                        txtAddFirstName.Text,
                                        txtAddLastName.Text,
                                        txtAddEmail.Text,
                                        dateTimeAddEmployee.Text,
                                        txtAddPhone.Text);

                // set up the empController to add the employee and check for success
                lblStatus.Text = UpdateEmployeeResult(emp);
            }
        }

        /// <summary>
        /// updates an employees details and returns a string with the result
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        private string UpdateEmployeeResult(Employee emp)
        {
            ResultsEnum result = _empController.Update(emp);
            if (result == ResultsEnum.Success)
            {
                LoadEmployeeData(); // update the home page with the new data
                return @"Employee details updated";
            }
            return @"Update failed, check the fields and try again";
        }

        /// <summary>
        /// Deletes an employee based on the Id entered
        /// </summary>
        /// <param name="id"></param>
        private void DeleteEmployeeById(int id)
        {
            ResultsEnum result = _empController.Delete(id);
            if (result == ResultsEnum.Success)
            {
                lblStatus.Text = @"Employee Deleted";
                LoadEmployeeData(); // update the home page
                ClearTextFields();
            }
            else
            {
                lblStatus.Text = @"Could not delete, check all the fields and try again";
            }
        }

        #endregion

        #region ADD/UPDATE Text Box Validation Methods

        /// <summary>
        /// Checks agains each and every text field and returns the correct error message
        /// if one isnt valid
        /// </summary>
        /// <returns></returns>
        private bool CheckTextBoxes()
        {
            if (!CheckFirstName())
            {
                return false;
            }

            if (!CheckLastName())
            {
                return false;
            }

            if (!CheckPhone())
            {
                return false;
            }

            return CheckEmail();
        }

        /// <summary>
        /// Checks to make sure the ID box is blank
        /// </summary>
        /// <returns></returns>
        private bool CheckId()
        {
            if (Validation.IsEmptyString(txtAddId.Text))
            {
                return true;
            }
            lblStatus.Text = @"ID must be blank - ID will be assigned automatically";
            return false;
        }

        /// <summary>
        /// checks the First Name box for empty or all whitespeace or numbers
        /// </summary>
        /// <returns></returns>
        private bool CheckFirstName()
        {
            if (Validation.IsEmptyString(txtAddFirstName.Text))
            {
                ErrorMessage(txtAddFirstName, lblStatus, "First Name can not be blank");
                return false;
            }
            if (!Validation.IsLettersOnly(txtAddFirstName.Text))
            {
                ErrorMessage(txtAddFirstName, lblStatus, "First Name must be letters only");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks the Last name for null, whitespace or numbers
        /// </summary>
        /// <returns></returns>
        private bool CheckLastName()
        {
            if (Validation.IsEmptyString(txtAddLastName.Text))
            {
                ErrorMessage(txtAddLastName, lblStatus, "Last Name can not be blank");
                return false;
            }
            if (!Validation.IsLettersOnly(txtAddLastName.Text))
            {
                ErrorMessage(txtAddLastName, lblStatus, "Last Name must be letters only");
                return false;
            }
            return true;
        }

        /// <summary>
        /// checks phone number for null, too long, or if there are wrong characters
        /// </summary>
        /// <returns></returns>
        private bool CheckPhone()
        {
            if (Validation.IsEmptyString(txtAddPhone.Text))
            {
                ErrorMessage(txtAddPhone, lblStatus, "Phone number can not be blank");
                return false;
            }

            if (txtAddPhone.Text.Length > 20)
            {
                ErrorMessage(txtAddPhone, lblStatus, "Phone number is too long");
                return false;
            }

            if (!Validation.IsValidPhoneNumber(txtAddPhone.Text))
            {
                lblStatus.Text = @"Please enter a valid phone number";
                return false;
            }
            return true;

        }

        /// <summary>
        /// checks the email field for null, whitespace and invalid format
        /// </summary>
        /// <returns></returns>
        private bool CheckEmail()
        {
            if (Validation.IsEmptyString(txtAddEmail.Text))
            {
                ErrorMessage(txtAddEmail, lblStatus, "Email cannot be empty");
                return false;
            }
            if (Validation.IsCorrectEmail(txtAddEmail.Text))
            {
                return true;
            }

            ErrorMessage(txtAddEmail, lblStatus, "Check that the email entered is valid");
            return false;
        }

        /// <summary>
        /// returns a relevant error message on failing validation and focus the the cursor on the relevant textbox
        /// </summary>
        /// <param name="textbox"></param>
        /// <param name="status"></param>
        /// <param name="error"></param>
        private void ErrorMessage(TextBox textbox, Label status, string error)
        {
            status.Text = error;
            textbox.Focus();
        }
        #endregion

        #region ADD/UPDATE helper methods

        /// <summary>
        /// clears all the text boxes in the add/update tab
        /// </summary>
        private void ClearTextFields()
        {
            foreach (Control c in tabAddUpdate.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = string.Empty;
                }
            }
            txtAddId.Focus();
        }

        /// <summary>
        /// Clears the current status text underneath the buttons. Used when each button is pressed
        /// </summary>
        private void ClearStatusText()
        {
            lblStatus.Text = "";
            btnDelete.Visible = false;
        }

        /// <summary>
        /// Removes the time string from the end of the birthdates so they only display the year
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        private string RemoveTimeFromBirthDate(string date)
        {
            return date.Substring(0, 10);
        }

        /// <summary>
        /// Test the validity of the Id number and prevents code running if invalid
        /// </summary>
        /// <returns></returns>
        private bool IsValidIdNumber()
        {
            if (!int.TryParse(txtAddId.Text, out _))
            {
                lblStatus.Text = @"Invalid Id, whole numbers only. Try again";
                return false;
            }
            return true;
        }

        /// <summary>
        /// Checks to see if there is an error/status message, if not, shows the delete button
        /// as it assumes that the search was successful
        /// </summary>
        private void CheckStatusForExtraButtons()
        {
            if (lblStatus.Text == "")
            {
                btnDelete.Visible = true;
                btnDecreaseId.Visible = true;
                btnIncreaseId.Visible = true;
            }
            else btnDelete.Visible = false;
        }
        #endregion


        #region HOURS BUTTONS

        /// <summary>
        /// Adjusts the other listboxes depending on which employee Id is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstbxEmpID_SelectedIndexChanged(object sender, EventArgs e)
        {
            HoursIndexChanged();
        }

        /// <summary>
        /// Adjusts the end date so that it cannot be before the start date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimeSartDate_ValueChanged(object sender, EventArgs e)
        {
            var startDate = DateTime.Parse(dateTimeSartDate.Text);
            var endDate = DateTime.Parse(dateTimeEndDate.Text);

            if (startDate > endDate)
            {
                dateTimeEndDate.Text = startDate.ToLongDateString();
            }
        }

        /// <summary>
        /// adjust the start date so it cannot be after the end date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimeEndDate_ValueChanged(object sender, EventArgs e)
        {
            var startDate = DateTime.Parse(dateTimeSartDate.Text);
            var endDate = DateTime.Parse(dateTimeEndDate.Text);

            if (endDate < startDate)
            {
                dateTimeSartDate.Text = endDate.ToLongDateString();
            }
        }

        /// <summary>
        /// Searches between a date range and returns all the hours and days worked for that range
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDateSearch_Click_1(object sender, EventArgs e)
        {
            DateTime startDate = DateTime.Parse(dateTimeSartDate.Text);
            DateTime endDate = DateTime.Parse(dateTimeEndDate.Text);

            if (endDate < startDate)
            {
                lblHoursStatus.Text = @"End date cannot be before start date";
            }
            SearchBetweenDates(startDate, endDate);
        }

        /// <summary>
        /// returns an employees hours by Id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHoursEmployeeSearch_Click(object sender, EventArgs e)
        {
            int id = int.Parse(cmbHoursEmployeeId.Text);
            SearchHoursById(id);
        }

        /// <summary>
        /// takes you to a separate form to add hours
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddHours_Click(object sender, EventArgs e)
        {
            AddHours frm = new AddHours();
            frm.Show();
        }

        #endregion

        #region HOURS Methods

        /// <summary>
        /// Searches between two dates entered, returns a list of EmployeeHours object
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        private void SearchBetweenDates(DateTime start, DateTime end)
        {
            Result<EmployeeHours> dateRangeResult = _hoursController.GetHoursInDateRange(start, end);
            if (dateRangeResult.Status == ResultsEnum.Success)
            {
                PopulateHoursListBox(dateRangeResult);
            }
        }

        /// <summary>
        /// Shows the employee's details depending on which Id is selected in the list box
        /// </summary>
        private void HoursIndexChanged()
        {
            // get the employe id of the date selected
            EmployeeHours selectedEmployee = (EmployeeHours)lstbxHoursEmpID.SelectedItem;
            int empId = selectedEmployee.EmpID;

            // return those employee details by running the search method
            ResultFind employee = _empController.FindEmployeeById(empId); // uses that Id to search for the employee

            // fills the label boxes with their details
            lblHoursEmail.Text = employee.Employee.Email;
            lblHoursName.Text = employee.Employee.FullName;
            lblHoursPhone.Text = employee.Employee.Phone;
        }

        /// <summary>
        /// search for the days and hours worked by an employees id
        /// </summary>
        /// <param name="id"></param>
        private void SearchHoursById(int id)
        {
            Result<EmployeeHours> hoursById = _hoursController.GetHoursById(id);

            if (hoursById.Status == ResultsEnum.Success)
            {
                if (hoursById.Data.Count == 0)
                {
                    lblHoursStatus.Text = @"No employee hours to display";
                }
                PopulateHoursListBox(hoursById);
            }
        }

        /// <summary>
        /// fills the list boxes with the list returned from a search
        /// </summary>
        /// <param name="result"></param>
        public void PopulateHoursListBox(Result<EmployeeHours> result)
        {
            lstbxHoursEmpID.DataSource = result.Data;
            lstbxHoursEmpID.DisplayMember = "EmpID";
            lstbxHoursDaysWorked.DataSource = result.Data;
            lstbxHoursDaysWorked.DisplayMember = "WorkDate";
            lstbxHoursWorked.DataSource = result.Data;
            lstbxHoursWorked.DisplayMember = "Hours";
        }

        #endregion

    }
}
