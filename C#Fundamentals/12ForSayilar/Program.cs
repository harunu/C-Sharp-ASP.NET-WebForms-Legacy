using System;

namespace _12ForSayilar
{
    class Program
    {
        static void Main(string[] args)
        {

            int toplam;
            int count = 0;
            {
                toplam = 0;
            }
            bool a = (toplam % 5) == 0;
            a = !a;

            for (int i = 0; i < 1000; i++)
            {
                if ((i % 5 == 0) && (i % 7 != 0))
                {
                    Console.WriteLine(i);
                    toplam = toplam + i;
                    count++;
                }
            }
            Console.WriteLine("{1,10} Toplamda {0,20} tane sayi bulundu ve aritmetik toplamarı : {1}", count, toplam);
            Console.ReadLine();
        }
    }
}
