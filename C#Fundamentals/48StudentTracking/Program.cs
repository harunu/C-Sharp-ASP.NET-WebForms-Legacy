using _50RandomNumberPackage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48StudentTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            LogHelper lh = new LogHelper();
            lh.Log("This is our first log.");

            lh.Log("basdfasdfasd");

            lh.Log(".......");

            _50RandomNumberPackage.GetRandomNumber rng = new GetRandomNumber();
            Console.WriteLine(rng.GetNumber());

            Console.Read();
        }
    }
}
