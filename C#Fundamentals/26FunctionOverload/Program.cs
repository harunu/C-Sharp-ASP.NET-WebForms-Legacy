using System;

namespace _26FunctionOverload
{
    class Program
    {
        static void Write(string text)
        {
            Console.WriteLine(text);
        }

        static void Write(string text, int howManyTimes)
        {
            Console.WriteLine(text.ToString());
        }

        /// <summary>
        /// Adds two numbers
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// Multiplies two numbers (despite the name)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="shouldAdd"></param>
        /// <returns></returns>
        static double Add(int a, int b, bool shouldAdd)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            string d = "hello";
            Write("pen");
            double b = 50;
            //Write(b);
            Write(d, 10);
            Console.WriteLine(b);
            Console.WriteLine(d);

            Console.ReadLine();
        }
    }
}
