using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49Abstract2
{
    abstract class Living
    {
        public abstract string Speak();
    }

    class Cat : Living
    {
        public override string Speak()
        {
            return "Meow";
        }
    }

    class Dog : Living
    {
        public override string Speak()
        {
            return "Woof Woof";
        }
    }
}
