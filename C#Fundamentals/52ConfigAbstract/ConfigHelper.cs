using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52ConfigAbstract
{
    class ConfigHelper
    {
        public Config CreateConfigObject()
        {
            return new XmlConfig();
        }

    }
}
