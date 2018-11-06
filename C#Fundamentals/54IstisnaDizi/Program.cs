using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54IstisnaDizi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] dizi = { "Elma", "Armut", "Portakal", "Erik", "Kiraz" };
            giris:
            Console.WriteLine("Dizinin kaçıncı elemanını görmek istiyorsunuz?");

            try
            {
                int eleman = int.Parse(Console.ReadLine());

                int s = 19 / eleman;
                Console.WriteLine(dizi[eleman]);

            }
            catch (IndexOutOfRangeException recep)
            {
                System.Console.WriteLine(recep.Message);
                Console.WriteLine(recep.GetType());
                Console.WriteLine("Dizide bulunmayan bir sayı girdiniz.");
                goto giris;
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Sayı gir demedik mi de böyle bir giriş yaptınız :( ?");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiç tahmin etmediğimiz bir hata meydana geldi.");
                Console.WriteLine(ex.GetType());
            }
            finally
            {

                Console.WriteLine("Sizinle çalışmak güzeldi.");
            }

            Console.WriteLine("Merhaba Dünya");


            Console.ReadLine();

        }
    }
}
