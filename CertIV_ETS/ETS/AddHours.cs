using System;
using System.Windows.Forms;
using Model;
using Controller;

namespace ETS
{
    public partial class AddHours : Form
    {
        private readonly EmployeeController _empController = new EmployeeController();
        private readonly HoursController _hoursController = new HoursController();
        private readonly EmpTracker _empTracker = new EmpTracker();

        public AddHours()
        {
            InitializeComponent();
        }

        private void AddHours_Load(object sender, EventArgs e)
        {
            LoadValues();
        }

        /// <summary>
        /// load the form with the values currently in the database
        /// </summary>
        private void LoadValues()
        {
            Result<Employee> data = _empController.GetAll();
            if (data.Status == ResultsEnum.Success)
            {
                // populate all the list boxes and combo boxes
                cmbHoursId.DataSource = data.Data;
                cmbHoursId.DisplayMember = "EmpId";

                cmbEmployeeName.DataSource = data.Data;
                cmbEmployeeName.DisplayMember = "FullName";
            }
        }

        /// <summary>
        /// add an employees hours to the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddHours_Click(object sender, EventArgs e)
        {
            // checks to make sure only numbers in the hours fields. All the other
            // fields will already be ok
            if (!int.TryParse(txtAddHours.Text, out _))
            {
                lblAddHoursStatus.Text = @"Numbers only";
                return;
            }

            // create the employeehours object
            var newEmpHours = new EmployeeHours
            {
                EmpHoursID = int.Parse(cmbHoursId.Text),
                WorkDate = DateTime.Parse(dateTimeAddHours.Text),
                Hours = int.Parse(txtAddHours.Text)
            };

            // update the status box with success or fail of adding the hours
            lblAddHoursStatus.Text = EmployeeHoursAdded(newEmpHours);
            
        }

        /// <summary>
        /// returns a string depending on the success or failure of adding the hours
        /// </summary>
        /// <param name="hours"></param>
        /// <returns></returns>
        private string EmployeeHoursAdded(EmployeeHours hours)
        {
            ResultsEnum result = _hoursController.AddHours(hours);
            if (result != ResultsEnum.Success)
            {
                return "Hours not added.. check all the fields and try again";
            }
            _empTracker.LoadEmployeeHours(); // update the new employee hours
            return "Employee hours added";
        }
    }
}
