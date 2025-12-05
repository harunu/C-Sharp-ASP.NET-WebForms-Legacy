using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //FirstExamples();
            Person person1 = new Person();
            Person teacherPerson = new Teacher();

            teacherPerson.Age = 19;

            IncrementAge(teacherPerson);

            Console.WriteLine(teacherPerson.Age);

            Console.ReadLine();

        }



        public static void IncrementAge(Person person)
        {

            person.Age += 1;

        }

        private static void FirstExamples()
        {
            Teacher teacher = new Teacher();

            teacher.Name = "Selami";
            teacher.WhatIsYourName();

            Console.Read();

            teacher.Name = "Ahmet";

            Student student = new Student();

            student.Name = "Mehmet";

            teacher.WhatIsYourName();
            student.WhatIsYourName();

            Console.ReadLine();

          //  Living.Tiger t = new Living.Tiger();

         //   t.Type = "asdfasd";
        }
    }
}
