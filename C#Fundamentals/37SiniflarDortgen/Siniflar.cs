using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37SiniflarDortgen
{
    class Siniflar
    {
        private int En;
        private int Boy;

        public int Eni
        {
            set
            {
                if (value > 0)
                {
                    En = value;
                }
            }
            get
            {
                return En;
            }
        }

        public int Boyu
        {
            set
            {
                if (value > 0)
                {
                    Boy = value;
                }
            }
            get
            {
                return Boy;
            }
        }

        public string DortgenAdi;

        public void EnBoyTanimla(int En, int Boy)
        {
            if (En > 0)
            {
                this.En = En;
            }
            else
            {
                this.En = 1;
            }

            if (Boy > 0)
            {
                this.Boy = Boy;
            }
            else
            {
                this.Boy = 1;
            }

            if (this.En == this.Boy)
            {
                this.DortgenAdi = "Kare";
            }
            else
            {
                this.DortgenAdi = "Dörtgen";
            }
        }

        public double Kosegen()
        {
            return Math.Sqrt((En * En) + (Boy * Boy));
        }
    }

}

