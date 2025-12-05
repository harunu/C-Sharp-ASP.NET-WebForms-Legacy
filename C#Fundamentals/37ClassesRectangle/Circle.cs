using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37ClassesRectangle
{
    class Circle
    {
        private int _radius;
        public int Radius
        {
            set
            {
                Console.WriteLine("Set method executed, incoming value = " + value);
                if (value > 0)
                {
                    _radius = value;


                }
            }

            get
            {
                return _radius;
            }

        }
    }
}

