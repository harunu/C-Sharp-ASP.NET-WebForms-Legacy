using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37SiniflarDortgen
{
    class Daire
    {
        private int _yaricap;
        public int YariCap
        {
            set
            {
                Console.WriteLine("Set metodu çalıştı gelen değer =" + value);
                if (value > 0)
                {
                    _yaricap = value;


                }
            }

            get
            {
                return _yaricap;
            }

        }
    }
}

