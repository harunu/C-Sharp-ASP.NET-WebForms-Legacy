using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57DistanceException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Distance m = new Distance();

                m.Kilometer = 19900;
            }
            catch (DistanceException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.DistanceIssue);

            }

            Console.ReadLine();


        }
    }
}
