using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35Fibonacci
{
    class Program
    {

        static int f(ref int x)
        {
            x = 0;
            return x;
        }

        void g()
        {
        }

        static double fib(double x)
        {
            if (x == 1 || x == 2)
            {
                return 1;
            }
            else
            {
                return fib(x - 1) + fib(x - 2);

            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine(fib(4));
            Console.ReadLine();
        }
    }
}
