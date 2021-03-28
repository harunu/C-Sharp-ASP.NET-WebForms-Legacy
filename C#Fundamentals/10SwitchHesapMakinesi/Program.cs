using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10SwitchHesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesaplama yapmak için değerleri girin");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Seçimizi yapın: +,-,*,/");
            string secim = Console.ReadLine();

            double sonuc = 0;

            switch (secim)
            {
                case "+":
                    sonuc = a + b;
                    break;
                case "-":
                    sonuc = a - b;
                    break;
                case "*":
                    sonuc = a * b;
                    break;
                case "/":
                    sonuc = a / b;
                    break;

                default:
                    Console.WriteLine("Yanlış seçimler pişmanlık yaratır.");
                    break;
            }
            Console.WriteLine("Sonuç : " + sonuc.ToString());
            Console.ReadLine();
        }
    }
}
