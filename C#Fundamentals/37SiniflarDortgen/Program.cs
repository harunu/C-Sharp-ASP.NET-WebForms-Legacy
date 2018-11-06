using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37SiniflarDortgen
{
    class Program
    {
        static void Main(string[] args)
        {
            //DorgenIsleri();

            //DaireIsleri();

            Musteri mter = new Musteri();
            mter.Adi = "Ahmet";
            mter.KrediNotu = 5;
            int kredi = mter.KrediVer();
            Console.WriteLine(kredi);
            Console.ReadLine();
        }

        private static void DaireIsleri()
        {
            Daire dr = new Daire();

            dr.YariCap = 5;

            int a = dr.YariCap;
        }

        private static void DorgenIsleri()
        {
            Siniflar sekil1 = new Siniflar();
            //sekil1.En = -10;
            //sekil1.Boy = 20;
            sekil1.EnBoyTanimla(10, 20);

            sekil1.Boyu = 6;

            Console.WriteLine(sekil1.Boyu);

            Console.WriteLine(sekil1.Kosegen());
            Console.WriteLine(sekil1.DortgenAdi);
        }
    }
}
