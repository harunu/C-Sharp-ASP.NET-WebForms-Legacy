using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60Delegates
{
    class Program
    {


        static void Main(string[] args)
        {
            //NewMethod();

            Operation op = new Operation();
            int result = op.PerformOperation(Add);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int Add(int a, int b)
        {
            return a - b;
        }

        private static void NewMethod()
        {
            DelegateClass dlg = new DelegateClass();
            dlg.DoDelegate();
        }
    }
}
