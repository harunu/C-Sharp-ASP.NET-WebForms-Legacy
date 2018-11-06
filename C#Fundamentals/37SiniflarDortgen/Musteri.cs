using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37SiniflarDortgen
{
    class Musteri
    {
        string _Adi, _HesapNo;
        int _KrediNotu;

        public string Adi
        {
            get
            {
                return _Adi;
            }
            set
            {
                _Adi = value;
            }
        }

        public string HesapNo
        {
            get
            {
                return _HesapNo;
            }
            set
            {
                _HesapNo = value;
            }
        }

        /// <summary>
        /// 1-5 arasında bir sayı
        /// </summary>
        public int KrediNotu
        {
            get
            {
                return _KrediNotu;
            }
            set
            {
                if (value <= 5 && value > 0)
                {
                    _KrediNotu = value;
                }

            }
        }

        /// <summary>
        /// KerediNotu * 10
        /// </summary>
        public int KrediVer()
        {
            return _KrediNotu * 10;
        }
    }
}

