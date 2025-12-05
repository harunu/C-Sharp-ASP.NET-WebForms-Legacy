using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48StudentTracking
{
    class LogHelper
    {

        public void Log(string LogMessage)
        {
            //We get the location from xml file.
            string location = ConfigurationSettings.AppSettings["LogLocation"];

            if (location == "Text")
            {
                TextLog log = new TextLog();
                log.Log(LogMessage);
            }
            else if (location == "Db")
            {
                DBLog dlog = new DBLog();
                dlog.Log(LogMessage);
            }
        }

        public void BadLog(string LogMessage, bool ToDatabase = false, bool ToWebService = false)
        {
            if (ToDatabase)
            {
                Console.WriteLine("Logged to database. Logged item: " + LogMessage);
            }
            else if (ToWebService)
            {
                Console.WriteLine("Logged to web service. Logged item: " + LogMessage);
            }
            else
            {
                Console.WriteLine("Logged to text file. Logged item: " + LogMessage);
            }
        }
    }
}
