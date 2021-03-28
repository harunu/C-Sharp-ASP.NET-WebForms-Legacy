using System;

namespace TurDonusumu
{

}
class Program
{
    static void Main(string[] args)
    {

        // SayisalDonusum();
        Console.Clear();

        string stringsayi = "25";
        int intsayi = int.Parse(stringsayi);
        int sayi = 456;
        string metin = sayi.ToString();
        metin = metin + "abc";
        Console.WriteLine(metin);
        Console.ReadLine();
    }

    private static void SayisalDonusum()
    {

        //byte a = 20;
        //int b = a;
        byte b;
        byte b2;

        float k = 5.6F;
        int m = (int)k;

        m = (int)'5';

        checked
        {
            int a = 1000;
            b = (byte)a;

            //Buralara kodlar yazacağım
            unchecked
            {
                int a2 = 300;
                b2 = (byte)a2;
            }
            //Buralara kodlar yazacağım
        }
        Console.WriteLine(b);
        Console.ReadLine();
    }
}