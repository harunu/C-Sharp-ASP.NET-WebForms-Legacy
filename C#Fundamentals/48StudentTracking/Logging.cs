using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48StudentTracking
{
    public abstract class Logging
    {
        public abstract void Log(string Message);
    }

    public class TextLog : Logging
    {

        public override void Log(string Message)
        {
            Console.WriteLine("Logged to text file. Logged item: " + Message);
        }
    }

    public class DBLog : Logging
    {
        public override void Log(string Message)
        {
            Console.WriteLine("Logged to DB. Logged item: " + Message);
        }
    }
}
