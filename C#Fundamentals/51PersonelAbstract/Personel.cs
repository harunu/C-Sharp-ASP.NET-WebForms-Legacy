using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51PersonelAbstract
{

    public interface ITelefonaBakabilir
    {
        void TelefonaBak();

    }

    public abstract class Personel
    {
        public abstract string Isim { get; set; }
        public abstract int Yas { get; set; }
        public decimal Ucret { get; set; }
        public abstract void Eylem();

        public void KendiniTanit()
        {
            Console.WriteLine("Adım : " + Isim);
        }
    }

    public class Mudur : Personel, ITelefonaBakabilir
    {

        public override string Isim
        {
            get;
            set;
        }

        private int _yas;
        public override int Yas
        {
            get
            {
                return _yas;
            }
            set
            {
                _yas = value;
            }
        }

        public override void Eylem()
        {
            Console.WriteLine("Ben bir müdürüm.");
        }

        public void TelefonaBak()
        {
            Console.WriteLine("Buyrun, ben kurumun müdürüyüm.");
        }
    }

    public class Isci : Personel
    {
        public override string Isim
        {
            get;
            set;
        }

        public override int Yas
        {
            get;
            set;
        }

        public override void Eylem()
        {
            Console.WriteLine("Ben bir işçiyim");
        }
    }

    public class Sekreter : Personel, ITelefonaBakabilir
    {
        public override string Isim
        {
            get;
            set;
        }

        public override int Yas
        {
            get;
            set;
        }

        public override void Eylem()
        {
            Console.WriteLine("Ben bir sekreterim.");
        }

        public void TelefonaBak()
        {
            Console.WriteLine("Kimi aramıştınız?");
        }
    }


}
