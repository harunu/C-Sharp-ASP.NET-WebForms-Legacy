using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48OgrenciTakip
{
    public abstract class Logging
    {
        public abstract void Logla(string Mesaj);

    }


    public class TextLog : Logging
    {

        public override void Logla(string Mesaj)
        {
            Console.WriteLine("Text dosyasına loglandı. Loglanan şey: " + Mesaj);
        }
    }

    public class DBLog : Logging
    {

        public override void Logla(string Mesaj)
        {
            Console.WriteLine("DB loglandı. Loglanan şey: " + Mesaj);
        }
    }
}
