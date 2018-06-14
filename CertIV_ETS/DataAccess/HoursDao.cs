using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
    public class HoursDao
    {
        /// <summary>
        /// Returns all the dates and hours worked
        /// </summary>
        /// <returns></returns>
        public List<EmployeeHours> SelectAllHours()
        {
            // create connection
            SqlConnection DbConnection = new SqlConnection
            {
                ConnectionString = ConnectionHelper.GetConnectionString()
            };
            DbConnection.Open();

            // set up the command
            using (DbConnection)
            {
                SqlCommand command = new SqlCommand("sp_EmpHours_SelectAllHours", DbConnection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // run the command through the reader
                SqlDataReader reader = command.ExecuteReader();

                // map the reader rows into Employee objects
                List<EmployeeHours> employeeHoursList = new List<EmployeeHours>();

                // set up a while loop that checks for data and stops executing when there is none
                while (reader.Read())
                {
                    var empHours = new EmployeeHours();
                    empHours.EmpHoursID = Convert.ToInt32(reader["EmpHoursID"]);
                    empHours.EmpID = Convert.ToInt32(reader["EmpID"]);
                    empHours.WorkDate = Convert.ToDateTime(reader["WorkDate"]);
                    empHours.Hours = Convert.ToInt32(reader["Hours"]);
                    employeeHoursList.Add(empHours);
                }

                return employeeHoursList;
            }
        }

        /// <summary>
        /// return a list of hours worked between a certain date range
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public List<EmployeeHours> SelectDateRange(DateTime start, DateTime end)
        {
            // create connection
            SqlConnection DbConnection = new SqlConnection
            {
                ConnectionString = ConnectionHelper.GetConnectionString()
            };
            DbConnection.Open();

            // set up the command
            using (DbConnection)
            {
                SqlCommand command = new SqlCommand("sp_EmpHours_SearchBetweenDates", DbConnection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // insert the parameters for the search
                command.Parameters.Add(new SqlParameter("@StartDate", start));
                command.Parameters.Add(new SqlParameter("@EndDate", end));

                // run the command through the reader
                SqlDataReader reader = command.ExecuteReader();

                // map the reader rows into Employee objects
                List<EmployeeHours> daterangeHoursList = new List<EmployeeHours>();

                // set up a while loop that checks for data and stops executing when there is none
                while (reader.Read())
                {
                    var empHours = new EmployeeHours();
                    empHours.EmpHoursID = Convert.ToInt32(reader["EmpHoursID"]);
                    empHours.EmpID = Convert.ToInt32(reader["EmpID"]);
                    empHours.WorkDate = Convert.ToDateTime(reader["WorkDate"]);
                    empHours.Hours = Convert.ToInt32(reader["Hours"]);
                    daterangeHoursList.Add(empHours);
                }

                return daterangeHoursList;
            }

        }

        /// <summary>
        /// returns a list of work hours by workers ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<EmployeeHours> SelectHoursById(int id)
        {
            // create connection
            SqlConnection DbConnection = new SqlConnection
            {
                ConnectionString = ConnectionHelper.GetConnectionString()
            };
            DbConnection.Open();

            // set up the command
            using (DbConnection)
            {
                SqlCommand command = new SqlCommand("sp_EmpHours_SearchHoursById", DbConnection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // insert the parameters for the search
                command.Parameters.Add(new SqlParameter("@empid", id));

                // run the command through the reader
                SqlDataReader reader = command.ExecuteReader();

                // map the reader rows into Employee objects
                List<EmployeeHours> hoursByIdList = new List<EmployeeHours>();

                // set up a while loop that checks for data and stops executing when there is none
                while (reader.Read())
                {
                    var empHours = new EmployeeHours();
                    empHours.EmpHoursID = Convert.ToInt32(reader["EmpHoursID"]);
                    empHours.EmpID = Convert.ToInt32(reader["EmpID"]);
                    empHours.WorkDate = Convert.ToDateTime(reader["WorkDate"]);
                    empHours.Hours = Convert.ToInt32(reader["Hours"]);
                    hoursByIdList.Add(empHours);
                }
                return hoursByIdList;
            }
        }

        /// <summary>
        /// add a workers hours to the database
        /// </summary>
        /// <param name="empHours"></param>
        public void AddHours(EmployeeHours empHours)
        {
            // create connection
            SqlConnection dbConnection = new SqlConnection
            {
                ConnectionString = ConnectionHelper.GetConnectionString()
            };
            dbConnection.Open();

            using (dbConnection)
            {
                // implement the stored procedure command
                SqlCommand command = new SqlCommand("sp_EmpHours_InsertEmployeeHours", dbConnection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                
                // pass through the parameters
                command.Parameters.Add(new SqlParameter("@empid", empHours.EmpHoursID));
                command.Parameters.Add(new SqlParameter("@workdate", empHours.WorkDate));
                command.Parameters.Add(new SqlParameter("@hours", empHours.Hours));

                // run the command
                command.ExecuteNonQuery();
            }
        }
    }
}

