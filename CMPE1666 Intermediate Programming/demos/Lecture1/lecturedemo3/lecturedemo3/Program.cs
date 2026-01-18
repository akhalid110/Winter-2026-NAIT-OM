using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecturedemo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
           
            int y = x;
            Console.WriteLine($"Initial value of x:{x} and y is{y}");
            x = 10;

            Console.WriteLine($"after modification value of x:{x} and y is{y}");
            Console.WriteLine();


            int[] a = new int[2];
            a[0]= 17;
            int[] b = a;
            Console.WriteLine($"Initial value of a[0]= {a[0]} and b[0]= {b[0]}");
            //since a and b are reference type , we note that changing the value of a[0] also changes the value of b[0] 
            a[0] = 25;
            Console.WriteLine($"after modication of a[0]become= {a[0]} and b[0]= {b[0]}");

        }
    }
}
