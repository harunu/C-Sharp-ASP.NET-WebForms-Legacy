using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _64DelegateEvent
{
    class Program
    {
        public delegate int BirTemsilci();

        public delegate void YazTemsilcisi();



        static void Main(string[] args)
        {
            //BasitKullanim();
            //BirdenFazlaMetot();


            BankaMusterisi musteri = new BankaMusterisi();

            musteri.BakiyeSifirinAltinaDustu += new BankaMusterisi.Temsilci(musteri_BakiyeSifirinAltinaDustu);

            musteri.Alacak = 90;
            musteri.Borc = 110;

            musteri.Alacak = 150;
            musteri.Borc = 140;



            musteri.Borc = 160;




            Console.ReadLine();


        }

        static void musteri_BakiyeSifirinAltinaDustu()
        {
            Console.WriteLine("bu da event ile");
        }


        public static void BakiyeEventHandler()
        {
            Console.WriteLine("Bakiye sıfırın altına düştü");
        }

        private static void BirdenFazlaMetot()
        {
            YazTemsilcisi yt = new YazTemsilcisi(AYaz);
            yt += BYaz;
            yt();
            Console.ReadLine();
        }

        private static void BasitKullanim()
        {
            int a = 5;
            BirTemsilci b = new BirTemsilci(SayiGetir);


            //b += SayiGetir;


            Console.WriteLine(b());
            Console.ReadLine();
        }



        public static void AYaz()
        {
            Console.WriteLine("a");
        }

        public static void BYaz()
        {
            Console.WriteLine("b");
        }

        public static int SayiGetir()
        {
            return 8;
        }
    }
}
