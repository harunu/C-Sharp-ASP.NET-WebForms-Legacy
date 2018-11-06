using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60Delegates
{
    class islem
    {
        public delegate int IslemMetodu(int a, int b);

        public int Operand1 { get; set; }
        public int Operand2 { get; set; }


        public int IslemYap(IslemMetodu isl)
        {
            return isl(Operand1, Operand2);
        }
    }
}
