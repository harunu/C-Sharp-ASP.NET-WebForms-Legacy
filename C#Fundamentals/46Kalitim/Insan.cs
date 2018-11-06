using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46Kalitim
{
    class Insan
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Yas { get; set; }

        protected int Gen;

        public Insan()
        {
            Console.WriteLine("Insan sınıfının ctor u");
        }

        public Insan(string adi, string soyadi)
        {
            Adi = adi;
            Soyadi = soyadi;
        }

        public void AdinNe()
        {
            if (Gen == 0)
            {
                return;
            }
            System.Console.WriteLine("Benim Adım + " + Adi.ToString());
        }
    }


    public enum Brans
    {
        Yazilim, VeriTabani, Donanim, Ag
    }

    class Ogretmen : Insan
    {
        public Ogretmen()
        {
            Console.WriteLine("Öğretmen sınıfının ctor u");

        }

        public Ogretmen(string adi, string soyadi, Brans brans = Brans.Yazilim)
            : base(adi, soyadi)
        {

            EgitmenlikBransi = brans;
        }

        new public void AdinNe()
        {

            Console.WriteLine("Ben {0} adında bir öğretmenim.", Adi);

            base.AdinNe();
        }


        Brans EgitmenlikBransi { get; set; }

    }

    class BuroPersoneli : Insan
    {
        public string FazlaMesaiGunleri { get; set; }

    }

    class Ogrenci : Insan
    {
        public string AldigiKurs { get; set; }
    }

    class Yonetici
    {
    }
}
