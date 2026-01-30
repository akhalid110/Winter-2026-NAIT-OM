using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4Demo3
{
    internal class StaticSample
    {
        //static fields 
        private static Random rand = null;
        private static int iStaticRand;

        //Static property
        public static int CurrentRand => iStaticRand;

        // instance property, utilizing static members
        public int InstanceRand => rand.Next(0, StaticSample.CurrentRand);

        // Static CTOR - runs before instance CTOR..
        static StaticSample()
        {
            rand = new Random(DateTime.Now.Millisecond); // initialize Random object which takes seed as argument
            iStaticRand = rand.Next(100, 200); // set static random value, won't change
        }

    }
}
