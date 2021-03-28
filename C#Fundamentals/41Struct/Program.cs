using System;

namespace _41Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogr1 = new Ogrenci(1);
            ogr1.AdSoyad = "Ahmet XYZ";
            ogr1.Yas = 12;

            Ogrenci ogr2 = ogr1;
            ogr2.Yas = 15;

            Console.WriteLine(ogr1.Yas);
            Console.Read();
        }
    }
}
