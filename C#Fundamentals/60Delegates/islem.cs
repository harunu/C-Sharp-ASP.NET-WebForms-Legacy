using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _60Delegates
{
    class Operation
    {
        public delegate int OperationMethod(int a, int b);

        public int Operand1 { get; set; }
        public int Operand2 { get; set; }


        public int PerformOperation(OperationMethod op)
        {
            return op(Operand1, Operand2);
        }
    }
}
