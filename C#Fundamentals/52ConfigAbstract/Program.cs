using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52ConfigAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Config k = (new ConfigHelper()).CreateConfigObject();

            k.WriteConfig("asda", "asda");

            Console.WriteLine(k.ReadConfig("asda"));

            Console.ReadLine();
        }
    }
}
