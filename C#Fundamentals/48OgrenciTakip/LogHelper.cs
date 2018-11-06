using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48OgrenciTakip
{
    class LogHelper
    {

        public void Logla(string LogMesasage)
        {
            //Lokasyonu xml dosyadan alıyoruz.
            string lokasyon = ConfigurationSettings.AppSettings["LogLocation"];

            if (lokasyon == "Text")
            {
                TextLog log = new TextLog();
                log.Logla(LogMesasage);
            }
            else if (lokasyon == "Db")
            {
                DBLog dlog = new DBLog();
                dlog.Logla(LogMesasage);
            }

        }

        public void KotuLogla(string LogMessage, bool VeriTabaninami = false, bool WebServisinemi = false)
        {
            if (VeriTabaninami)
            {
                Console.WriteLine("Veri tabanına loglandı. Loglanan şey: " + LogMessage);
            }
            else if (WebServisinemi)
            {
                Console.WriteLine("Web servisine loglandı. Loglanan şey: " + LogMessage);
            }
            else
            {
                Console.WriteLine("Text dosyasına loglandı. Loglanan şey: " + LogMessage);
            }

        }
    }
}
