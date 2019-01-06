using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChipperSample
{
    class UnlistedPhone
    {
        Ichipher crypt;

        public string _name;
        
        public string Name
        {
            get { return  crypt.decode(_name); }
            set { _name = crypt.encode(value); }
        }

        public string _number;

        public string Number
        {
            get { return 
                crypt.decode(_number); }
            set { _number = crypt.encode(value); }
        }


        public UnlistedPhone(string name, string number, Ichipher c) {

            crypt = c;
            Name = name;
            Number = number;

        
        }

    }
}
