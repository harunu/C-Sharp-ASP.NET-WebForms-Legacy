using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _67GenericDelegates
{
    class Program
    {
        public delegate void FunctionDelegate(string s);

        public delegate void GenericDelegate<T>(T k);

        static void Main(string[] args)
        {
            //FunctionDelegate a = new FunctionDelegate(PrintToScreen);
            //a += PrintToScreenDouble;
            //a("hello");

            GenericDelegate<string> k = new GenericDelegate<string>(PrintToScreen);
            k("kkkkkk");

            GenericDelegate<int> e = new GenericDelegate<int>(PrintIntToScreen);
            e(5);
        }
        public static void PrintIntToScreen(int i)
        {
            Console.WriteLine(i);
            Console.ReadLine();
        }

        public static void PrintToScreen(string s)
        {
            Console.WriteLine(s);
            Console.ReadLine();
        }

        public static void PrintToScreenDouble(string s)
        {
            Console.WriteLine(s);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
