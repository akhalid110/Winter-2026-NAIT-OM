using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace demo_struct
{
    internal class Program
    {
        struct myPoint
        {
            public int _x;
            public int _y;
        }
        static void Main(string[] args)
        {
            myPoint P1 = new myPoint{_x = 2, _y = 5};
            myPoint P2 = P1;
            Console.WriteLine("Initial points P1 and P2");
            Console.WriteLine($"P1:{P1._x},{P1._y}");
            Console.WriteLine($"P2:{P2._x},{P2._y}");

            P2._x = 3;
            P2._y = 7;

            Console.WriteLine();
            Console.WriteLine("After modifying P2, points P1 and P2 are now ");
            Console.WriteLine($"P1:{P1._x},{P1._y}");
            Console.WriteLine($"P2:{P2._x},{P2._y}");
            Console.WriteLine();
            int[] array1 = { 20, 30, 40, 50 };
            int[] array2 = array1;
            Console.WriteLine("Initial array value");
            Console.WriteLine($"array: {string.Join(", ", array1)}");
            Console.WriteLine($"array: {string.Join(", ", array2)}");

            Console.WriteLine();
            array2[1] = 35;
            array2[2] = 65;
            Console.WriteLine("after modification the array value become.");
            Console.WriteLine($"array: {string.Join(", ", array1)}");
            Console.WriteLine($"array: {string.Join(", ", array2)}");

           
            Console.ReadKey();
        }
    }
}
