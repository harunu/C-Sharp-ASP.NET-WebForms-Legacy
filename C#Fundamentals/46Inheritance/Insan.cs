using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46Inheritance
{
    class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        protected int Gen;

        public Person()
        {
            Console.WriteLine("Person class constructor");
        }

        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public void WhatIsYourName()
        {
            if (Gen == 0)
            {
                return;
            }
            System.Console.WriteLine("My name is " + Name.ToString());
        }
    }


    public enum Branch
    {
        Software, Database, Hardware, Networking
    }

    class Teacher : Person
    {
        public Teacher()
        {
            Console.WriteLine("Teacher class constructor");
        }

        public Teacher(string name, string lastName, Branch branch = Branch.Software)
            : base(name, lastName)
        {
            TeachingBranch = branch;
        }

        new public void WhatIsYourName()
        {
            Console.WriteLine("I am a teacher named {0}.", Name);
            base.WhatIsYourName();
        }
        Branch TeachingBranch { get; set; }
    }

    class OfficeStaff : Person
    {
        public string OvertimeDays { get; set; }

    }

    class Student : Person
    {
        public string EnrolledCourse { get; set; }
    }

    class Manager
    {
    }
}
