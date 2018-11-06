using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36Siniflar
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            string k;

            Insan insan1;
            insan1 = new Insan();
            insan1.Nasilsin();
            Console.WriteLine(insan1.Paraver());
            Console.ReadLine();
        }
    }
}
