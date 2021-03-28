using OttoFramework.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44Namespace
{
    class Program
    {
        static void Main(string[] args)
        {

            OttoFramework.ORM.Config a = new OttoFramework.ORM.Config();
            OttoFramework.Logging.WriteLog w = new OttoFramework.Logging.WriteLog();
            OttoFramework.ORM.TestConnection tc = new TestConnection();
            OttoFramework.ORM.Config c = new OttoFramework.ORM.Config();
        }
    }
}
