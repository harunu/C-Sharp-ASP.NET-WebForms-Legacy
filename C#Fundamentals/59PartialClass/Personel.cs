using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59PartialClass
{
    partial class Employee
    {
        public int EmployeeNo { get; set; }
        public string EmployeeName { get; set; }
        public int GetNumber()
        {
            return 1;
        }
    }
}
