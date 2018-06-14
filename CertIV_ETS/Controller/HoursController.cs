using System;
using Model;
using DataAccess;

namespace Controller
{
    public class HoursController
    {
        // add the data access object
        private HoursDao HoursDao;
        public HoursController()
        {
            HoursDao = new HoursDao();
        }

        /// <summary>
        /// Return all the dates and hours worked
        /// </summary>
        /// <returns></returns>
        public Result<EmployeeHours> GetAllHours()
        {
            Result<EmployeeHours> allEmployeeHours = new Result<EmployeeHours>();

            try
            {
                allEmployeeHours.Data = HoursDao.SelectAllHours();
                allEmployeeHours.Status = ResultsEnum.Success;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in GetAllHours/HoursController" + e.Message);
                allEmployeeHours.Status = ResultsEnum.Fail;
            }
            return allEmployeeHours;
        }

        /// <summary>
        /// return all the days and hours worked within a certain date range
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public Result<EmployeeHours> GetHoursInDateRange(DateTime start, DateTime end)
        {
            Result<EmployeeHours> dateRangeHours = new Result<EmployeeHours>();
            try
            {
                dateRangeHours.Data = HoursDao.SelectDateRange(start, end);
                dateRangeHours.Status = ResultsEnum.Success;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in GetHoursInDateRange/HoursController" + e.Message);
                dateRangeHours.Status = ResultsEnum.Fail;
            }

            return dateRangeHours;
        }

        public Result<EmployeeHours> GetHoursById(int id)
        {
            Result<EmployeeHours> hoursById = new Result<EmployeeHours>();
            try
            {
                hoursById.Data = HoursDao.SelectHoursById(id);
                hoursById.Status = ResultsEnum.Success;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in GetHoursInDateRange method/HoursController" + e.Message);
                hoursById.Status = ResultsEnum.Fail;
            }
            return hoursById;
        }

        public ResultsEnum AddHours(EmployeeHours emp)
        {
            try
            {
                HoursDao.AddHours(emp);
                return ResultsEnum.Success;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error from HoursDAO/AddHours" + e.Message);
                return ResultsEnum.Fail;
            }
        }
    }
}
