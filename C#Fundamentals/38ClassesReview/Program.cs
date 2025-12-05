using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38ClassesReview
{
    class Program
    {
        static void Main(string[] args)
        {
            //Age should be between 1-120 and for those named BetulCan, age cannot be greater than 50.

            Student student = new Student("Ahmet");
            //student.Name = "Ahmet";
            student.LastName = "Yasar";
            student.SetAge(121);

            //student.Age = 16;

            Console.WriteLine(student.GetAge());

            student.Speak();
            Console.ReadLine();
        }
    }
}
