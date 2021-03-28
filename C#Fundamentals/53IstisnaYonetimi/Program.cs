using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53IstisnaYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc;
            bool girisbasarili = false;
            do
            {
                Console.WriteLine("Bölme işlemi için iki sayı giriniz:");
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                sonuc = 0;
                try
                {
                    sonuc = a / b;
                    sonuc++;
                    --sonuc;
                    girisbasarili = true;

                    //Close
                }
                catch (Exception)
                {
                    girisbasarili = false;

                    Console.WriteLine("0 girmeniz büyük hata oldu.");
                }
                finally
                {

                }

            } while (girisbasarili == false);

            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
