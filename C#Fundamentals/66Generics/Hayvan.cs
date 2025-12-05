using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66Generics
{
    public class Animal : IComparable
    {
        public string Name { get; set; }
        public virtual string Speak()
        {
            return "I am " + Name;
        }

        public int Age { get; set; }

        public int CompareTo(object obj)
        {
            if (this.Age < ((Animal)obj).Age)
            {
                return -1;
            }
            else if (this.Age == ((Animal)obj).Age)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }

    public class Cat : Animal
    {

        public override string Speak()
        {
            return "I meow. My name is " + Name;
        }
    }

    public class Dog : Animal
    {

        public override string Speak()
        {
            return "I woof woof. My name is " + Name;
        }
    }


    public class Speaker<T> where T : Animal, new()
    {
        public string MakeSpeak()
        {
            T animal1 = new T();
            return animal1.Speak();
        }
    }
}
