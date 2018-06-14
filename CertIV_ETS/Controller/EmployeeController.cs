using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAccess;

namespace Controller
{
    public class EmployeeController
    {
        // add a private data access object
        private EmployeeDao EmpDao;
        public EmployeeController()
        {
            EmpDao = new EmployeeDao();
        }

        /// <summary>
        /// Adds an employee to the database and returns an Enum with success or fail
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public ResultsEnum Add(Employee emp)
        {
            try
            {
                EmpDao.AddEmployee(emp);
                return ResultsEnum.Success;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error from EmployeeDAO/AddEmployee" + e.Message);
                return ResultsEnum.Fail;
            }
        }

        /// <summary>
        /// Update an employees details via ID number
        /// </summary>
        /// <param name="emp"></param>
        /// <returns></returns>
        public ResultsEnum Update(Employee emp)
        {
            try
            {
                EmpDao.UpdateEmployee(emp);
                return ResultsEnum.Success;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error from EmployeeDAO/UpdateEmployee" + e.Message);
                return ResultsEnum.Fail;
            }
        }

        public ResultsEnum Delete(int id)
        {
            try
            {
                EmpDao.DeleteById(id);
                return ResultsEnum.Success;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error from EmployeeDAO/DeleteEmployee" + e.Message);
                return ResultsEnum.Fail;
            }
        }

        public ResultFind FindEmployeeById(int id)
        {
            ResultFind foundEmployee = new ResultFind();
            try
            {
                foundEmployee.Employee = EmpDao.SelectById(id);
                if (foundEmployee.Employee.FirstName != null)
                {
                    foundEmployee.Status = ResultsEnum.Success;
                    return foundEmployee;
                }
                foundEmployee.Status = ResultsEnum.Fail;
                return foundEmployee;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in FindByID method/EmployeeController" + e.Message);
                foundEmployee.Status = ResultsEnum.Fail;
                return foundEmployee;
            }
        }

        /// <summary>
        /// Gets all employee records from the database, returns a list if successful,
        /// or returns an 'fail' enum if not
        /// </summary>
        /// <returns></returns>
        public Result<Employee> GetAll()
        {
            Result<Employee> getAllEmployees = new Result<Employee>();
            try
            {
                getAllEmployees.Data = EmpDao.SelectAll();
                getAllEmployees.Status = ResultsEnum.Success;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in GetAll method/EmployeeController" + e.Message);
                getAllEmployees.Status = ResultsEnum.Fail;
            }

            return getAllEmployees;
        }

    }
}
