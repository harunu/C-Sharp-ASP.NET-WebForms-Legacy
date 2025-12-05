using System;

namespace _41Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(1);
            student1.FullName = "Ahmet XYZ";
            student1.Age = 12;

            Student student2 = student1;
            student2.Age = 15;

            Console.WriteLine(student1.Age);
            Console.Read();
        }
    }
}
