using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _63MultiMethodDelegate
{
    class Program
    {

        public delegate void WriteMethodDelegate();


        static void Main(string[] args)
        {
            WriteMethodDelegate variable;
            variable = new WriteMethodDelegate(Write1);
            variable += Write2;
            variable -= Write1;
            variable();
            Console.ReadLine();
        }

        static void Write1()
        {
            Console.WriteLine("Write1 method was called.");
        }

        static void Write2()
        {
            Console.WriteLine("Write2 method was called.");
        }
    }
}
