using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7Demo2
{
    internal class CBox
    {
        private int _width;
        private int _height;

        public CBox(int Height, int Width)
        {
            this._width = Width;
            this._height = Height;

        }
        public override string ToString()
        {
            return $"({_width},{_height})";
        }

        public static bool IsBig(CBox box)
        {
            return box._width * box._height > 15;
        }
        public int Area
        {
            get
            {
                return _width*_height;
            }
          
        }
    }
}
