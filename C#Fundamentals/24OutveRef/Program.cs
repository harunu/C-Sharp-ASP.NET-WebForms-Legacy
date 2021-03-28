using System;

namespace _24OutveRef
{
    class Program
    {

        #region IlkMetotlarımız
        static double Kare(double a)
        {
            return a * a;
        }


        /// <summary>
        /// Bu metot verilen sayının karesini ve kökünü hesaplayarak geriye döndürür.
        /// </summary>
        /// <param name="a">Karesi ve kökü hesaplanacak sayıdır.</param>
        /// <param name="ka">Girinlen sayının karesi</param>
        /// <param name="ko">Girilen sayının kökü</param>
        /// <returns>Eğer sayı çift ise true değilse false döner</returns>
        public static bool KaresiKoku(double a, out double ka, out double ko)
        {
            ka = a * a;
            ko = Math.Sqrt(a);

            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ToplaCarp(double a, double b, out double toplam, out double carpim)
        {
            toplam = a + b;
            carpim = a * b;
        }
        #endregion



        static void Main(string[] args)
        {
            double top, carp;

            ToplaCarp(10, 30, out top, out carp);
            double koku, karesi;
            bool deger = KaresiKoku(25, out karesi, out koku);
            KaresiKoku(10, out karesi, out koku);

            //double a = double.Parse(Console.ReadLine());

            double a;

            bool donusturmesonucu = double.TryParse(Console.ReadLine(), out a);
            if (donusturmesonucu == true)
            {
                Console.WriteLine("Teşekkürler doğru bir giriş yaptınız. Sayı : {0}", a);
            }
            else
            {
                Console.WriteLine("Böyle kullanıcı olmaz olsun. Yanlış.");
            }

            Console.WriteLine(karesi);
            double sonuc = top + carp;
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
