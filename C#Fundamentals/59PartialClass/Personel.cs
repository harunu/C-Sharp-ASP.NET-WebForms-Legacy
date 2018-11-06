using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _59PartialClass
{
    partial class Personel
    {
        public int PersonelNo { get; set; }
        public string PersonelAdi { get; set; }
        public int NoGetir()
        {
            return 1;
        }
    }
}
