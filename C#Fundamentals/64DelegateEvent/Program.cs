using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64DelegateEvent
{
    class Program
    {
        public delegate int ADelegate();
        public delegate void WriteDelegate();



        static void Main(string[] args)
        {
            //SimpleUsage();
            //MultipleMethods();


            BankCustomer customer = new BankCustomer();

            customer.BalanceDroppedBelowZero += new BankCustomer.Delegate(customer_BalanceDroppedBelowZero);

            customer.Credit = 90;
            customer.Debt = 110;

            customer.Credit = 150;
            customer.Debt = 140;



            customer.Debt = 160;




            Console.ReadLine();


        }

        static void customer_BalanceDroppedBelowZero()
        {
            Console.WriteLine("this is also with event");
        }


        public static void BalanceEventHandler()
        {
            Console.WriteLine("Balance dropped below zero");
        }

        private static void MultipleMethods()
        {
            WriteDelegate wd = new WriteDelegate(WriteA);
            wd += WriteB;
            wd();
            Console.ReadLine();
        }

        private static void SimpleUsage()
        {
            int a = 5;
            ADelegate b = new ADelegate(GetNumber);


            //b += GetNumber;


            Console.WriteLine(b());
            Console.ReadLine();
        }



        public static void WriteA()
        {
            Console.WriteLine("a");
        }

        public static void WriteB()
        {
            Console.WriteLine("b");
        }

        public static int GetNumber()
        {
            return 8;
        }
    }
}
