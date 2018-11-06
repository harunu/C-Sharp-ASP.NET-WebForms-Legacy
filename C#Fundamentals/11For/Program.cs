using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11For
{
    class Program
    {
        static void Main(string[] args)
        {
            int degisken = 0;
            string strLog = string.Empty;
            for (; degisken < 50; strLog = strLog + degisken.ToString() + " - ")
            {
                Console.WriteLine(degisken);
                degisken += (DateTime.Now.Millisecond % 10);
            }

            degisken = 0;
            for (Console.ReadLine(); degisken < 50; degisken = degisken + 6)
            {
                Console.WriteLine(degisken);

            }

            Console.WriteLine(strLog);
            Console.ReadLine();
        }
    }
}
