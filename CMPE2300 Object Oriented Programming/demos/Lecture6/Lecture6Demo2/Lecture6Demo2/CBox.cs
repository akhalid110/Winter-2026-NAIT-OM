
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Demo2
{
    internal class CBox : IComparable
    {
            private int _width;
            private int _height;

            public CBox(int width, int height)
            {
                _width = width;
                _height = height;
            }


            //override Equals
            public override bool Equals(object? obj)
            {
                if (!(obj is CBox arg)) return false;
                return (_width == arg._width && _height == arg._height);
            }
        public override int GetHashCode()
        {
            return 1;
        }

        public override string ToString()
            {
                return $"({_width},{_height})";
            }

        //A CompareTo method that supports 2-tier ordering
        public int CompareTo(object? obj)
        {
            if (!(obj is CBox argBox))
                throw new ArgumentException($"CBox: CompareTo {nameof(obj)} - is invalid");

            int iReturn = _width.CompareTo(argBox._width);
            if (iReturn == 0) // Widths are the same ! Must Check next tier, Height
                iReturn = _height.CompareTo(argBox._height); // Compare Height
                                                           // iReturn should hold appropriate tier outcome
            return iReturn;

        }
    }
}
