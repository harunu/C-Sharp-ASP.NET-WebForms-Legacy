using System;

namespace VeriTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Object Tipi
             * C# da kullandığımız her şey object türünden bir nesnedir. 
             * 
             * /       
            /*Merhaba bu uygulamayı şu tarihte geliştirdik: Şu maddeler yapıldı:
            
             * Değerlendirme kısmı yapıldı
             * ABCD ye göre değiştirildi....
            dce yapıldı*/

            object k = 1;
            object m = 2;
            m = k;
            m = 7;
            Console.WriteLine(k);

            object degisken = 1;
            Console.WriteLine(degisken);
            Console.WriteLine(degisken.GetType());
            Console.WriteLine("--------");

            degisken = "abc";
            Console.WriteLine(degisken);
            Console.WriteLine(degisken.GetType());
            Console.WriteLine("--------");

            degisken = 5.6F;
            Console.WriteLine(degisken);
            Console.WriteLine(degisken.GetType());
            Console.WriteLine("--------");

            degisken = 'A';
            Console.WriteLine(degisken);
            Console.WriteLine(degisken.GetType());
            Console.WriteLine("--------");

            Console.ReadLine();
            Console.Clear();

            float a = 5F;
            float b = 2F;

            decimal c = 65.9M;
            char karakter = 'A';
            karakter = (char)45;
            string metin = "\t Atatürk Diyor ki :\n  \"İstikbal göklerdedir.\"";

            string yol = "D:\\08_DropBox\\Dropbox\\01_DersPanlari\\MCPDBT";
            string yol2 = @"D:\08_DropBox\Dropbox\01_DersPanlari\""MCPDBT""";

            //TODO:  Bu kısma isimi yazdıracak kodları ekleyeceğim
            //Console.WriteLine(isim);
            Console.WriteLine(a / b);
            Console.WriteLine(karakter);
            Console.WriteLine(metin);
            Console.WriteLine(yol2);
            Console.Read();
        }
    }
}
