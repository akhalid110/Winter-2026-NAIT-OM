using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Demo1
{
    internal class CBox : IComparable
    {
        private int _width;
        private int _height;

        public CBox(int width , int height)
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

        public override string ToString()
        {
            return $"Width : {_width} and Height : {_height}";
        }
        public int CompareTo(object obj)
        {
            if (!(obj is CBox arg))
                throw new ArgumentException($"CBox: CompareTo {nameof(obj)} - is invalid");
            return (_width * _height).CompareTo(arg._width * arg._height);
        }
    }

}
