using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58ExamQuestion
{
    class ExampleClass
    {
        int a;

        //public int Increment(int k, whichFunction)
        //{
        //    return k + 1;
        //}
    }


    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            int m = 3;

            ExampleClass o = new ExampleClass();
            //k = o.Increment(k);
            //m = o.Increment(m);
        }

        int Function1(int h)
        {
            Console.WriteLine("First function");
            return h--;
        }

        int Function2(int h)
        {
            Console.WriteLine("Second function");
            return h + 2;
        }
    }
}
