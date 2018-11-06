using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52ConfigAbstract
{
    public abstract class Config
    {
        public abstract void WriteConfig(string key, string value);
        public abstract string ReadConfig(string key);
    }

    public class DbConfig : Config
    {
        public override void WriteConfig(string key, string value)
        {
            Console.WriteLine("Ayarlar veri tabanına yazıldı.");
        }

        public override string ReadConfig(string key)
        {
            return "Veri tabanından ilgili ayar bilgisi döndürüldü";
        }
    }

    public class TextConfig : Config
    {
        public override void WriteConfig(string key, string value)
        {
            Console.WriteLine("Text dosyasına ilgili ayar yazıldı.");
        }

        public override string ReadConfig(string key)
        {
            return "Text dosyasından değer getirildi.";
        }
    }

    public class XmlConfig : Config
    {
        public override void WriteConfig(string key, string value)
        {
            Console.WriteLine("XML dosyasına veriler yazıldı.");
        }

        public override string ReadConfig(string key)
        {
            return "XML dosyasından veriler olundu";
        }
    }
}
