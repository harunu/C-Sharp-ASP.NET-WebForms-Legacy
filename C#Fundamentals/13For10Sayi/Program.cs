using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13For10Sayi
{
    class Program
    {

        static void Main(string[] args)
        {

            int toplam = 0;
            double ortalama = 0;
            int enkucuk = 0;

            for (int i = 0; i < 10; i++)
            {


                Console.Write("{0}. Sayıyı giriniz :", i + 1);
                int sayi = int.Parse(Console.ReadLine());
                toplam = toplam + sayi;
                ortalama = toplam / (i + 1);
                if (i == 0)
                {
                    enkucuk = sayi;
                }
                else
                {
                    if (sayi < enkucuk)
                    {
                        enkucuk = sayi;
                    }
                }

                Console.WriteLine("Toplam : " + toplam);
                Console.WriteLine("Ortalama : " + ortalama);

            }

            Console.WriteLine("Girdiğiniz sayıların en küçüğü : " + enkucuk);
            Console.ReadLine();


        }



    }
}
