using System;

namespace _51EmployeeAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager m = new Manager();
            HireEmployee(m);

            Secretary s = new Secretary();
            HireEmployee(s);

            AnswerPhoneCall(s);
            AnswerPhoneCall(m);
            Console.ReadLine();
        }

        static void HireEmployee(Employee emp)
        {
            emp.PerformAction();
        }

        static void AnswerPhoneCall(ICanAnswerPhone person)
        {
            person.AnswerPhone();
        }
    }
}
