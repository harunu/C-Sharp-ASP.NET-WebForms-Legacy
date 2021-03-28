using System;

namespace _38SiniflarTekrar
{
    class Ogrenci
    {
        /* Erişim belirleyiciler:
         * public : Herkes erişebilir 
         * private : Sınıfın kendi içerisinde erişilebiliyordu
         */

        public Ogrenci(string Adi)
        {
            Yas = 16;
            this.Adi = Adi;
        }

        private int _Numara;

        public int Numara
        {
            get
            {
                return _Numara;
            }
            set
            {
                _Numara = value;
            }
        }


        public string Adi;
        public string Soyadi;
        private int Yasi;

        public void SetYasi(int value)
        {
            if (value > 0 && value < 120)
            {
                if ((value > 50 && (Adi != "BetülCan")) || value < 50)
                {
                    Yasi = value;
                    return;
                }
            }

            throw new Exception("Yaşı özelliğine böyle bir değer atanamaz");
        }

        public int GetYasi()
        {
            return Yasi;
        }

        public int Yas
        {
            get
            {
                return Yasi;
            }

            private set
            {
                if (value > 0 && value < 120)
                {
                    if ((value > 50 && (Adi != "BetülCan")) || value < 50)
                    {
                        Yasi = value;
                        return;
                    }
                }
            }
        }
        public void Konus()
        {
            Console.WriteLine("Ben bir öğrenciyim, adım da {0}", Adi);
        }
    }
}
