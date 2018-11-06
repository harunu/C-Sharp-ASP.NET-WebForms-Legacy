using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            bool birinci = true;
            bool ikinci = false;
            bool ucuncu = false;

            bool sonuc = (birinci || ikinci) && ucuncu;

            int a = 5;
            int b = 6;

            a = (b == 5) ? (b * 2) : (b * 3);

            int intsonuc = ((((a + 5) * 4) - b) + 3);
            intsonuc = intsonuc + -b;

            b = a++;

            Console.WriteLine(a);
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
