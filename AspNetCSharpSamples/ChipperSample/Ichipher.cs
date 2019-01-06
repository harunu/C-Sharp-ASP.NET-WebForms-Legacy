using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChipperSample
{
    public interface Ichipher
    {
        string encode(string str);
        string decode(string str);

    }
}
