using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51EmployeeAbstract
{

    public interface ICanAnswerPhone
    {
        void AnswerPhone();

    }

    public abstract class Employee
    {
        public abstract string Name { get; set; }
        public abstract int Age { get; set; }
        public decimal Salary { get; set; }
        public abstract void PerformAction();

        public void IntroduceYourself()
        {
            Console.WriteLine("My name is: " + Name);
        }
    }

    public class Manager : Employee, ICanAnswerPhone
    {

        public override string Name
        {
            get;
            set;
        }

        private int _age;
        public override int Age
        {
            get
            {
                return _age;
            }
            set
            {
                _age = value;
            }
        }

        public override void PerformAction()
        {
            Console.WriteLine("I am a manager.");
        }

        public void AnswerPhone()
        {
            Console.WriteLine("Hello, I am the institution's manager.");
        }
    }

    public class Worker : Employee
    {
        public override string Name
        {
            get;
            set;
        }

        public override int Age
        {
            get;
            set;
        }

        public override void PerformAction()
        {
            Console.WriteLine("I am a worker.");
        }
    }

    public class Secretary : Employee, ICanAnswerPhone
    {
        public override string Name
        {
            get;
            set;
        }

        public override int Age
        {
            get;
            set;
        }

        public override void PerformAction()
        {
            Console.WriteLine("I am a secretary.");
        }

        public void AnswerPhone()
        {
            Console.WriteLine("Who were you looking for?");
        }
    }


}
