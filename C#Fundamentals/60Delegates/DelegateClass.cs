using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60Delegates
{
    class DelegateClass
    {
        public delegate void YazDelege();
        public YazDelege delege = new YazDelege(Yaz);

        public static void Yaz()
        {
            Console.WriteLine("Merhaba Dünya");
        }
    }
}
