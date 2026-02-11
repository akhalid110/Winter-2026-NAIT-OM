using Lecture6Demo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Demo3
{
    internal class MyCompareClass: IComparable<CBox>
    {
        public enum ESortType { Ascendinng,Descending }
        public ESortType SortType { get; set; }

        public MyCompareClass()
        {
            SortType = ESortType.Ascendinng;
        }
        public int Compare(CBox cbox1,CBox cbox2)
        {
            switch (SortType)
            {
                case ESortType.Ascendinng:
                    return cbox1.CompareTo(cbox2);
                case ESortType.Descending:
                    return -1 * cbox1.CompareTo(cbox2);
                default:
                    break;
            }
            return 0;
        }
    }
}
