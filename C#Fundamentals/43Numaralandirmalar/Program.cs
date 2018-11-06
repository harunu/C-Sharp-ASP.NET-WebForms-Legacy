using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43Numaralandirmalar
{
    class Musteri
    {
        public enum MusteriTuru
        {
            Alici, Satici, Hepsi
        }

        public enum Gunler
        {
            Pazartesi, Sali, Carsamba, Persembe, Cuma, Cumartesi, Pazar
        }


        public string MusteriAdi { get; set; }

        /// <summary>
        /// Alıcı için 1 satıcı için 2, her ikisi se 3 girin
        /// </summary>
        public MusteriTuru MTuru { get; set; }

        public string HesapDokumu(Gunler gun)
        {

            Console.WriteLine(gun.ToString() + " gününün dökümü");

            return "";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Musteri a = new Musteri();
            a.MusteriAdi = "Kelimator";
            a.MTuru = Musteri.MusteriTuru.Alici;

            //a.HesapDokumu(Musteri.Gunler.Sali);
            string[] gunlerstr = Enum.GetNames(typeof(Musteri.Gunler));

            Musteri.Gunler k = (Musteri.Gunler)4;

            int i = 1;
            foreach (string gun in gunlerstr)
            {
                Console.WriteLine(i.ToString() + " - " + gun);
                i++;
            }


            Console.WriteLine("Hangi günün raporunu almak istiyorsunuz?");
            int gundegeri = int.Parse(Console.ReadLine());



            a.HesapDokumu((Musteri.Gunler)(gundegeri - 1));

            Console.Read();


        }
    }
}
