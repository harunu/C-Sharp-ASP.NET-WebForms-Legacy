using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42BilgisayarClass
{
    class Bilgisayar
    {
        /// <summary>
        /// Hz cinsinden işlemci hızı
        /// </summary>
        public int IslemciHizi { get; set; }


        private int _ram;
        /// <summary>
        /// Ram in kapasitesi, byte cinsinden
        /// </summary>
        public int Ram
        {
            get
            {
                return _ram;
            }

            set
            {
                _ram = value + value % 2;
            }
        }


        private long _disk;
        /// <summary>
        /// Diskin Kapasitesi byte cinsinden.
        /// </summary>
        public long Disk
        {
            get
            {
                return _disk;
            }
            set
            {
                _disk = value + (int)(value) % 2;
            }
        }

        public Bilgisayar(int cpu, int ram)
        {
            this.IslemciHizi = cpu;
            this.Ram = ram;
        }

        public int IslemYap(int IslemMiktari)
        {
            if (IslemMiktari > Ram)
            {
                return 0;
            }

            return IslemMiktari / IslemciHizi;
        }

        public bool DiskeYaz(string Yazilacak)
        {
            long boyut = Yazilacak.Length;
            if (Disk > boyut)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
