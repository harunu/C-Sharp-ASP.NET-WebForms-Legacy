using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23Functions
{
  class Program
    {
        static void Main(string[] args)
        {
            int x = 5;

            int result = (((x * x) + 2) - (2 * (x * x + 2))) / 4 * (x * x + 2);
            result = (f(x) - 2 * f(x)) / 4 * f(x);

            Console.WriteLine(result);

            PrintTimeToScreen();
            PrintTimeToScreen();
            PrintTimeToScreen();
            PrintTimeToScreen();
            PrintTimeToScreen();
            PrintTimeToScreen();
            PrintTimeToScreen();

            Console.WriteLine(Add(5, 6));

            int a = 5;
            Function(a);

            Console.WriteLine(a);

            Console.ReadLine();
        }

        static int f(int x)
        {
            int result = (int)Math.Pow(x, 3) + 8;
            return result;
        }

        static int Add(int a, int b)
        {
            if (a > 5)
            {
                return a + b;
            }
            return a * b;
        }

        static void PrintTimeToScreen()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine("Of course this time is valid for Istanbul");
            return;
        }
        static void Function(int a)
        {
            a = a * 2;
            return;
        }
    }
}
