using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61DelegateArama
{
    class DiziAra
    {
        public string[] Ara(string[] AranacakDizi, string aranan)
        {
            string[] sonuc = new string[AranacakDizi.Length];

            int bulunansayi = 0;
            foreach (string metin in AranacakDizi)
            {
                if (metin == aranan)
                {
                    sonuc[bulunansayi] = aranan;
                    bulunansayi++;
                }
            }

            return sonuc;
        }


        public delegate bool DiziAramaFonskiyonu(string aranan);

        public string[] Ara(string[] AranacakDizi, DiziAramaFonskiyonu AramaFonksiyonu)
        {
            string[] sonuc = new string[AranacakDizi.Length];

            int bulunansayi = 0;
            foreach (string metin in AranacakDizi)
            {
                if (AramaFonksiyonu(metin))
                {
                    sonuc[bulunansayi] = metin;
                    bulunansayi++;
                }
            }
            return sonuc;
        }

    }
}
