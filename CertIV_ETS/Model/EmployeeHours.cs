using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class EmployeeHours
    {
        #region attributes

        public int EmpHoursID { get; set; }
        public int EmpID { get; set; }
        public DateTime WorkDate { get; set; }
        public int Hours { get; set; }

        #endregion

        #region Constructors

        public EmployeeHours() { }

        public EmployeeHours(int emphours, int id, DateTime date, int hours)
        {
            EmpHoursID = emphours;
            EmpID = id;
            WorkDate = date;
            Hours = hours;
        }
        #endregion

    }
}
