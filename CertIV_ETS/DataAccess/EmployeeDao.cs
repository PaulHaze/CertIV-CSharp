using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DataAccess
{
    public class EmployeeDao
    {

        // methods that need to be done

        // 3. enter the employees work hours

        // 4. generate a report.



       /// <summary>
       /// Method that adds a new employee to the database
       /// </summary>
       /// <param name="employee"></param>
        public void AddEmployee(Employee employee)
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
                SqlCommand command = new SqlCommand("sp_Employees_InsertEmployee", dbConnection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // convert the date of birth from string into a date format
                DateTime dateOfBirth = DateTime.Parse(employee.DateOfBirth);
                
                // pass through the parameters
                command.Parameters.Add(new SqlParameter("@FirstName", employee.FirstName));
                command.Parameters.Add(new SqlParameter("@LastName", employee.LastName));
                command.Parameters.Add(new SqlParameter("@email", employee.Email));
                command.Parameters.Add(new SqlParameter("@dob", dateOfBirth));
                command.Parameters.Add(new SqlParameter("@phone", employee.Phone));

                // run the command
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Updates an employee in the database via ID
        /// </summary>
        /// <param name="employee"></param>
        public void UpdateEmployee(Employee employee)
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
                SqlCommand command = new SqlCommand("sp_Employees_UpdateEmployee", dbConnection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // convert the date of birth from string into a date format
                DateTime dateOfBirth = DateTime.Parse(employee.DateOfBirth);

                // pass through the parameters
                command.Parameters.Add(new SqlParameter("@empid", employee.EmpID));
                command.Parameters.Add(new SqlParameter("@FirstName", employee.FirstName));
                command.Parameters.Add(new SqlParameter("@LastName", employee.LastName));
                command.Parameters.Add(new SqlParameter("@email", employee.Email));
                command.Parameters.Add(new SqlParameter("@dob", dateOfBirth));
                command.Parameters.Add(new SqlParameter("@phone", employee.Phone));

                // run the command
                command.ExecuteNonQuery();
            }
        }

        public Employee SelectById(int id)
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
                SqlCommand command = new SqlCommand("sp_Employees_SelectEmployeeByID", dbConnection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@empid", id));

                SqlDataReader reader = command.ExecuteReader();
  

                var emp = new Employee();
                while (reader.Read())
                {
                    emp.EmpID = Convert.ToInt32(reader["EmpID"]);
                    emp.FirstName = Convert.ToString(reader["FirstName"]);
                    emp.LastName = Convert.ToString(reader["LastName"]);
                    emp.Email = Convert.ToString(reader["Email"]);
                    emp.DateOfBirth = Convert.ToString(reader["DOB"]);
                    emp.Phone = Convert.ToString(reader["Phone"]);
                }
                return emp;
            }      
        }

        public void DeleteById(int id)
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
                SqlCommand command = new SqlCommand("sp_Employees_DeleteEmployee", dbConnection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // pass through the parameter
                command.Parameters.Add(new SqlParameter("@empid", id));

                // run the command
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Returns a List of all the employees in the database
        /// </summary>
        /// <returns></returns>
        public List<Employee> SelectAll()
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
                SqlCommand command = new SqlCommand("sp_Employees_SelectAll", DbConnection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                // run the command through the reader
                SqlDataReader reader = command.ExecuteReader();

                // map the reader rows into Employee objects
                List<Employee> employeeList = new List<Employee>();

                // set up a while loop that checks for data and stops executing when there is none
                while (reader.Read())
                {
                    var emp = new Employee();
                    emp.EmpID = Convert.ToInt32(reader["EmpID"]);
                    emp.FirstName = Convert.ToString(reader["FirstName"]);
                    emp.LastName = Convert.ToString(reader["LastName"]);
                    emp.Email = Convert.ToString(reader["Email"]);
                    emp.DateOfBirth = Convert.ToString(reader["DOB"]);
                    emp.Phone = Convert.ToString(reader["Phone"]);
                    employeeList.Add(emp);
                }
                return employeeList;
            }
 
        }
   
    }
}
