using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64DelegateEvent
{
    class BankaMusterisi
    {

        public delegate void Temsilci();


        public event Temsilci BakiyeSifirinAltinaDustu;

        private decimal _bakiye;
        public decimal Bakiye
        {
            get
            {
                return _bakiye;
            }
            private set
            {
                _bakiye = value;
                if (_bakiye < 0)
                {
                    if (BakiyeSifirinAltinaDustu != null)
                    {
                        BakiyeSifirinAltinaDustu();
                    }

                }
            }
        }


        private decimal _alacak;
        public decimal Alacak
        {
            get
            {
                return _alacak;
            }
            set
            {
                _alacak = value;
                Bakiye = Alacak - Borc;
            }

        }


        private decimal _borc;
        public decimal Borc
        {
            get
            {
                return _borc;
            }
            set
            {
                _borc = value;
                Bakiye = Alacak - Borc;
            }
        }

    }
}
