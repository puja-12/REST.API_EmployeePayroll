using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employeepayroll_REST_API
{
    public class RestSharp
    {
        public class Employee
        {
            public int id { get; set; }
            public string Name { get; set; }
            public string Salary { get; set; }
        }
    }
}