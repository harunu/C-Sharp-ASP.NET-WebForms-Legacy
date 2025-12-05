using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60Delegates
{
    class DelegateClass
    {
        public delegate void WriteDelegate();
        public WriteDelegate DoDelegate = new WriteDelegate(Write);

        public static void Write()
        {
            Console.WriteLine("Hello World");
        }
    }
}
