using System;

namespace _40EmployeeClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee p = new Employee("Ahmet", "Soyalan", 45);
            Console.WriteLine(p.PayTax());
            Math.Abs(12);
            double calculated = Employee.CalculateTax(5000);
            Console.WriteLine(calculated);
            Console.Read();
        }
    }
}
