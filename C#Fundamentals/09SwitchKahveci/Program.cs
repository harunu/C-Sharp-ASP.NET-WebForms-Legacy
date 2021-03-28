using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09SwitchKahveci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kahvenin fiyatını giriniz : ");
            decimal fiyat = decimal.Parse(Console.ReadLine());
            Console.WriteLine("(B)üyük, (O)rta, (K)üçük seçiniz : ");
            string secim = Console.ReadLine();
            secim = secim.ToUpper();

            decimal tutar = 0;

            switch (secim)
            {
                case "B":
                    tutar = fiyat * 1.5M;
                    break;
                case "O":
                    tutar = fiyat * 1.25M;
                    break;
                case "K":
                    tutar = fiyat;
                    break;
                default:
                    Console.WriteLine("Yaptığınız seçim geçerli değil.");
                    break;
            }

            Console.WriteLine("Ürünün fiyatı : " + tutar.ToString());
            Console.ReadLine();
        }
    }
}
