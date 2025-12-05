using System;

namespace _27OverloadedMethod
{
    class Program
    {
        static void Operation(string a, string b)
        {
            Console.WriteLine(a + b);
        }

        static int Operation(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            int sum = Operation(2, 3);
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
