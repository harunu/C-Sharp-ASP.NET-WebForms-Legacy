using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49Abstract2
{
    abstract class Canli
    {
        public abstract string Konus();

    }

    class Kedi : Canli
    {

        public override string Konus()
        {
            return "Miyav";
        }
    }

    class Kopek : Canli
    {
        public override string Konus()
        {
            return "Hav Hav";
        }
    }
}
