using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38SiniflarTekrar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yaşı 1-120 arasında olsun ve ismi BetülCan olanların yaşı 50 den büyük olamasın.

            Ogrenci ogr = new Ogrenci("Ahmet");
            //ogr.Adi = "Ahmet";
            ogr.Soyadi = "Yaşar";
            ogr.SetYasi(121);

            //ogr.Yas = 16;

            Console.WriteLine(ogr.GetYasi());

            ogr.Konus();
            Console.ReadLine();
        }
    }
}
