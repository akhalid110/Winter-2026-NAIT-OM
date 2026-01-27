using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4Demo1
{
    internal class Ball
    {
        private int _diameter;

        public Ball(int dia)
        {
            _diameter = dia;
        }
        public static string color;
        public static void AssignColor(string col)
        {
            color = col;
        }

        public static void AssignDiameter(int dia)
        {
            
        }
    }
}
