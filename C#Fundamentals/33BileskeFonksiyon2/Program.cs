using System;

namespace _33BileskeFonksiyon2
{
    class Program
    {
        static double f(double x)
        {
            return Math.Sqrt(x);
        }

        static double g(double x)
        {
            return Math.Pow(x, 1d / 3d);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(f(g(569)));
            Console.ReadLine();
        }
    }
}
