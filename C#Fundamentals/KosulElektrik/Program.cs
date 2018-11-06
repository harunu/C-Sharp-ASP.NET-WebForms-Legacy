using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosulElektrik
{
    class Program
    {
        static void Main(string[] args)
        {
            int tuketim;

            //1&&67

            Console.Write("Tüketim miktarini giriniz : ");
            tuketim = int.Parse(Console.ReadLine());

            decimal tutar = 0;
            decimal birimfiyat = 40;

            if (tuketim <= 150)
            {
                birimfiyat = 10;
            }
            else if (tuketim < 300)
            {
                birimfiyat = 20;
            }

            tutar = birimfiyat * tuketim;

            Console.WriteLine(tutar);
            Console.ReadLine();

        }
    }
}
