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
        public int CompareTo(object? obj)
        {
            if (!(obj is CBox arg))
                throw new ArgumentException($"CBox: CompareTo {nameof(obj)} - is invalid");
            return (_width * _height).CompareTo(arg._width * arg._height);
        }

        public static int CompareOnWidth(object arg1, object arg2)
        {
            if (!(arg1 is CBox argBox1))
                throw new ArgumentException($"CBox: CompareTo:{nameof(arg1)} - Not a valid CBox");
            if (!(arg2 is CBox argBox2))
                throw new ArgumentException($"CBox: CompareTo:{nameof(arg2)} - Not a valid CBox");
            return argBox1._width.CompareTo(argBox2._width);
        }
        public static int CompareOnHeight(object arg1, object arg2)
        {
            if (!(arg1 is CBox argBox1))
                throw new ArgumentException($"CBox: CompareTo:{nameof(arg1)} - Not a valid CBox");
            if (!(arg2 is CBox argBox2))
                throw new ArgumentException($"CBox: CompareTo:{nameof(arg2)} - Not a valid CBox");
            return argBox1._height.CompareTo(argBox2._height);
        }
    }

}
