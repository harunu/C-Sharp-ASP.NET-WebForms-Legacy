using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51PersonelAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Mudur m = new Mudur();
            PeroselIseAl(m);

            Sekreter s = new Sekreter();
            PeroselIseAl(s);

            TelefonCevapla(s);
            TelefonCevapla(m);



            Console.ReadLine();
        }

        static void PeroselIseAl(Personel per)
        {
            per.Eylem();
        }


        static void TelefonCevapla(ITelefonaBakabilir per)
        {
            per.TelefonaBak();
        }
    }
}
