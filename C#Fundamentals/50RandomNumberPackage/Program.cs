using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50RandomNumberPackage
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    internal class RandomNumberGenerator
    {
        public delegate void Method();

        public class TestException : ApplicationException
        {

        }

        public int Generate(Method a)
        {
            a();
            return (new Random()).Next(1, 1000);

        }

        protected string SametProperty { get; set; }
    }

    public class GetRandomNumber
    {
        void Test()
        {
            Console.WriteLine("test");
        }

        public int GetNumber()
        {
            RandomNumberGenerator generator = new RandomNumberGenerator();
            return generator.Generate(Test);
        }
    }
}
