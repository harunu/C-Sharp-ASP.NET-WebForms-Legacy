using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GlobalSpyAnalysisApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Agency CIA = new Agency();
            CIA.AgencyName = "CIA";
            CIA.Country = "USA";
            CIA.OrganizationSize = 10000;

            Spy newSpy = new Spy();
            newSpy.CodeName = "Charles Charmichael";
            newSpy.DateLastSeen = DateTime.Now;
            newSpy.Notes = "The intesect";
            newSpy.SpyAgency = CIA;

            newSpy.DisplaySpyInfo();
            Console.ReadLine();
        }
    }
}
