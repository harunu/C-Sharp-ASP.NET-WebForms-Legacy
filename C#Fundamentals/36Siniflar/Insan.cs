using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36Siniflar
{
    public class Insan
    {
        public string Adi;
        public int Yasi;
        public string KanGrubu;

        private int Bonkurluk;

        private int SevkatBeklentisi;

        private double CepKontrol()
        {
            Random sans = new Random();
            double cebindeki = sans.Next(1, 100);
            return cebindeki;
        }


        public double Paraver()
        {
            double sahipolunan = CepKontrol();
            double verilecek = (Bonkurluk * sahipolunan) / 100;
            return verilecek;
        }


        public void Nasilsin()
        {
            if (SevkatBeklentisi > 50)
            {
                Console.WriteLine("Bunu sorman beni çok mutlu etti desin");
            }
            else
            {
                Console.WriteLine("Sana ne, yine borç mu isteyeceksin.");
            }
        }

        /// <summary>
        /// Bunu da sırf örnek olsun diye yaptık.
        /// </summary>
        public Insan()
        {
            Bonkurluk = (new Random()).Next(1, 100);
            Yasi = 0;
            KanGrubu = "0 rh /";
            Console.WriteLine("Parametresiz ctor çalıştı.");

            SevkatBeklentisi = (new Random()).Next(1, 100);
        }

        public void Konus()
        {
            Console.WriteLine("Ben {0} adında, {1} yaşında bir insanım.", Adi, Yasi);
        }

    }
}
