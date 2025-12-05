using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string k;

            Person person1;
            person1 = new Person();
            person1.HowAreYou();
            Console.WriteLine(person1.GiveMoney());
            Console.ReadLine();
        }
    }
}
