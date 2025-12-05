using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37ClassesRectangle
{
    class Rectangle
    {
        private int Width;
        private int Height;

        public int WidthProperty
        {
            set
            {
                if (value > 0)
                {
                    Width = value;
                }
            }
            get
            {
                return Width;
            }
        }

        public int HeightProperty
        {
            set
            {
                if (value > 0)
                {
                    Height = value;
                }
            }
            get
            {
                return Height;
            }
        }

        public string RectangleName;

        public void SetWidthHeight(int Width, int Height)
        {
            if (Width > 0)
            {
                this.Width = Width;
            }
            else
            {
                this.Width = 1;
            }

            if (Height > 0)
            {
                this.Height = Height;
            }
            else
            {
                this.Height = 1;
            }

            if (this.Width == this.Height)
            {
                this.RectangleName = "Square";
            }
            else
            {
                this.RectangleName = "Rectangle";
            }
        }

        public double Diagonal()
        {
            return Math.Sqrt((Width * Width) + (Height * Height));
        }
    }

}

