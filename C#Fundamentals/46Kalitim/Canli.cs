using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46Kalitim
{
    class Hayvan
    {
        public string Adi { get; set; }
        public int Yas { get; set; }
        public double Agirlik { get; set; }
    }

    class Kedi : Hayvan
    {
        public string Turu { get; set; }
    }

    class Balik : Hayvan
    {
        public enum SuTuru
        {
            Tatli, Tuzlu
        }
        public SuTuru YasamAlani { get; set; }
    }

    class Kertenkele
    {
        public enum Yer
        {
            Col, Savan
        }
        public Yer YasamAlani { get; set; }
    }

    class Kaplan : Kedi
    {
        public string Mensei { get; set; }
    }
}
