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

            islem i = new islem();
            int sonuc = i.IslemYap(Topla);
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }

        public static int Topla(int a, int b)
        {
            return a - b;
        }

        private static void NewMethod()
        {
            DelegateClass dlg = new DelegateClass();
            dlg.delege();
        }
    }
}
