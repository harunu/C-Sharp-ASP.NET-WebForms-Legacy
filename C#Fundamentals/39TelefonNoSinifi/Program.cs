using System;

namespace _39TelefonNoSinifi
{
    class TelefonNumarasi
    {
        private string _Turu;

        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Numara { get; set; }
        public string Turu
        {
            get
            {
                return _Turu;
            }
            set
            {
                switch (value)
                {
                    case "Ev":
                    case "Mobil":
                    case "İş":
                        _Turu = value;
                        break;
                    default:
                        _Turu = "Belirsiz";
                        break;
                }
            }
        }

        public void AramaYap()
        {
            Console.WriteLine(Adi + " " + Soyadi + " " + Numara + " aranıyor. Lütfen bekleyin");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TelefonNumarasi telno = new TelefonNumarasi()
            {
                Adi = "Ahmet",
                Soyadi = "Hünkar",
                Numara = "111111",
                Turu = "Yazane"
            };
            //telno.Adi = "Ahmet";
            //telno.Soyadi = "Hünkar";
            //telno.Numara = "055555555";
            //telno.Turu = "İş";
            telno.AramaYap();
            Console.WriteLine(telno.Turu);
            Console.Read();
        }
    }
}
