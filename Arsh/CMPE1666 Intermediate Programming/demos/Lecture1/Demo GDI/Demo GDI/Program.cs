using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Demo_GDI
{
    internal class Program
    {
         /// <summary>
         /// 
         /// </summary>
         /// <param name="args"></param>   
        private struct Circle
        {
           public Point center;
           public int _diameter;
           public Color color;
        }
        static void Main(string[] args)
        {
            Circle[] circles = new Circle[50];
            int count = 0; //to keep the track of number of circles
            CDrawer drawer = new CDrawer(600,400);
            Random random = new Random();
            
            
            while (true)
            {

                if (drawer.GetLastMouseLeftClick(out Point p))
                {
                    Console.WriteLine($"Mouse was Clicked:({p.X},{p.Y})");
                    int rnddiameter = random.Next(25,76);
                    circles[count] = new Circle { center = p, _diameter = rnddiameter, color = RandColor.GetColor() };
                    drawer.AddCenteredEllipse(circles[count].center, circles[count]._diameter, circles[count]._diameter, circles[count].color);
                    count++;
                }
                if (drawer.GetLastMouseRightClick(out Point P))
                {
                    for (int circlecount = 0; circlecount < count; circlecount++)
                    {
                        if (circles[circlecount]._diameter >= 50)
                        {
                            circles[circlecount].color = Color.Blue;
                        }

                    }
                    Render(drawer, circles, count);
                }


            }

            //while (true)
            //{

            //    if(drawer.GetLastMouseLeftClick(out Point p))
            //    {
            //        Console.WriteLine($"Mouse was Clicked:({p.X},{p.Y})");
            //        int diameter = 50;

            //        drawer.AddCenteredEllipse(p.X, p.Y, diameter, diameter, Color.Red);
            //    }

            //}

        }
        /// <summary>
        /// method Render  clears GDIDRawer window, iterates over the array and redraw them
        /// </summary>
        /// <param name="drawer">GDIDRawer window in which we redraw our circles</param>
        /// <param name="circles">an array of the circle</param>
        /// <param name="count">the total number of circles that array contain</param>
        static private void Render(CDrawer drawer, Circle[] circles, int count)
        {
            drawer.Clear();
            for (int counter = 0; counter < count; counter++)
            {
                drawer.AddCenteredEllipse(circles[counter].center, circles[counter]._diameter, circles[counter]._diameter, circles[counter].color);
            }

        }

    }
}
