using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40PersonelSinifi
{
    class Personel
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        private double Ucret { get; set; }
        public int PersonelID { get; private set; }
        public Personel(string Adi, string Soyadi, int PersonelID = 0)
        {
            this.Adi = Adi;
            this.Soyadi = Soyadi;
            Ucret = (new Random()).Next(700, 10000);
            this.PersonelID = PersonelID;
        }
        public double VergiVer()
        {
            return Ucret * 0.2;
        }

        public static double VergiHesapla(double ucret)
        {
            return ucret * 0.2;
        }
    }
}
