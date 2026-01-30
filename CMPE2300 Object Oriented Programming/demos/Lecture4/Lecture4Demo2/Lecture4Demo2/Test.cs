using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4Demo2
{
    internal class Test
    {
        public static Random r = new Random();
        private static int iStaticValue = 20;

        //Property to return iStaticValue
        public static int Value => iStaticValue;


        //Adding static Methods to the class test
        public static int GetRandomNumber(short upperLimit)
        {
            return r.Next(upperLimit);
        }

        public static string Excuse()
        {
            string[] messages = { "BS was down..", "Github was down..", "Teams was down.." };
            return messages[GetRandomNumber((short)messages.Length)];
        }

    }
}
