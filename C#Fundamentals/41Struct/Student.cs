using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41Struct
{
    struct Student
    {
        public int Age { get; set; }
        public string FullName { get; set; }

        public Student(int age)
        {
            Age = age;
            FullName = "";
        }
    }
}
