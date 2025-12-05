using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _65EventExample
{
    /*
     	• OnEk,Ad, OrtaAd,Soyad propertyleri olan bir Isim sinifi hazirlayalim.
     * Herhangi bir propertysi değiştiğinde PropertyChanged event ı 
     * tetiklensin, Eğer herhangi bir alana 20 karakterden fazla giriş yapılırsa da 
     * 20 karakterden fazla giriş yapıldı event ı tetiklensin.
 
     * */
    class Isim
    {

        private string _onek, _ad, _soyad, _ortaad;
        public string OnEk
        {
            get
            {
                return _onek;
            }
            set
            {
                _onek = value;
                DegerDegisti(value);
            }
        }

        public event EventHandler PropertyChanged;
        public event EventHandler Property20;
        private void DegerDegisti(string value)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new EventArgs());
            }

            if (value.Length > 20)
            {
                Property20(this, new EventArgs());
            }
        }

        public string Ad
        {
            get
            {
                return _ad;
            }
            set
            {
                _ad = value;
                DegerDegisti(value);
            }
        }

        public string Soyad
        {
            get
            {
                return _soyad;
            }
            set
            {
                _soyad = value;
                DegerDegisti(value);
            }
        }

        public string Ortaad
        {
            get
            {
                return _ortaad;
            }
            set
            {
                _ortaad = value;
                DegerDegisti(value);
            }
        }

    }
}
