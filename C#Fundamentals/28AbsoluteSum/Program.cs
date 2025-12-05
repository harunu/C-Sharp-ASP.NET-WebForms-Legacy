using System;

namespace _28AbsoluteSum
{
    class Program
    {
        static int AbsoluteSum(int a)
        {
            return Math.Abs(a);
        }

        static double AbsoluteSum(int a, int b)
        {
            return Math.Abs(a) + Math.Abs(b);
        }

        static void Main(string[] args)
        {
            var a = new int[10];
            var number = AbsoluteSum(1);

            number = number + 1;
            Console.WriteLine(number);
            Console.ReadLine();
        }
    }
}
