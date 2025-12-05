using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40EmployeeClass
{
    class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        private double Salary { get; set; }
        public int EmployeeID { get; private set; }
        public Employee(string Name, string LastName, int EmployeeID = 0)
        {
            this.Name = Name;
            this.LastName = LastName;
            Salary = (new Random()).Next(700, 10000);
            this.EmployeeID = EmployeeID;
        }
        public double PayTax()
        {
            return Salary * 0.2;
        }

        public static double CalculateTax(double wage)
        {
            return wage * 0.2;
        }
    }
}
