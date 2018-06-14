using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class ConnectionHelper
    {
        public static string GetConnectionString()
        {
            return "Data Source=.;Initial Catalog=EmpTracker;Integrated Security=True";
        }
    }
}


