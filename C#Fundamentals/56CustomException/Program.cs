using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56CustomException
{
    class MyException : ApplicationException
    {
        public string Message { get; set; }
        public MyException(int a, int b)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            MyException exc = new MyException(1, 1);

            throw exc;

        }
    }
}
