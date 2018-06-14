using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class Result<T>
    {
        public ResultsEnum Status { get; set; }
        public List<T> Data { get; set; }
    }

    public class ResultFind
    {
        public ResultsEnum Status { get; set; }
        public Employee Employee { get; set; }
    }
   
}
