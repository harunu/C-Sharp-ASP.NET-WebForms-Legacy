using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32CompositeFunction
{
    /*
     * Create a function that takes two int type parameters, but as a third parameter
     * take a bool type parameter for whether to convert to absolute value.
     * If the third parameter is true, convert to absolute value and return the sum,
     * if no value is entered or false, return the sum directly.
     */
    class Program
    {
        static int Add(int a, int b, bool TakeAbsoluteValue = true)
        {
            int sum = a + b;
            if (TakeAbsoluteValue)
            {
                return Math.Abs(sum);
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int s = Add(-5, -6, true);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
