using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57MesafeException
{
    class Mesafe
    {
        int _km;
        int _m;


        public int Kilometre
        {
            get
            {
                return _km;
            }
            set
            {
                if (value < 0)
                {
                    throw new MesafeException(value, this._m);
                }
                _km = value;
            }
        }
        public int Metre
        {
            get
            {
                return _m;
            }
            set
            {
                if (value < 0 || value > 999)
                {
                    throw new MesafeException(_km, value);
                }
                _m = value;
            }
        }


    }

    public class MesafeException : ApplicationException
    {


        string mesafesorun = "";

        public string MesafeSorun
        {
            get
            {
                return mesafesorun;
            }
            private set
            {
                mesafesorun = value;
            }
        }


        /// <summary>
        /// Mesafe sınıfında atamalarla ilgili bir hata olduğunda bu exception oluşturulur.
        /// </summary>
        /// <param name="kilometre">Hatalı km</param>
        /// <param name="metre">hatalı metre</param>
        public MesafeException(int kilometre, int metre)
        {
            if (kilometre < 0)
            {
                MesafeSorun += "Kilometre değerine 0 dan büyük bir değer girin. ";
            }

            if (metre < 0 || metre > 999)
            {
                MesafeSorun += "Metre değerine [0-1000) aralığında bir değer girin.";
            }
        }

        public string Message
        {
            get
            {
                return "Mesafe değeri hatalı girildi.";
            }
        }
    }
}
