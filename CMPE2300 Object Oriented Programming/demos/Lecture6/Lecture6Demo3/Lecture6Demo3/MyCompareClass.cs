using Lecture6Demo1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture6Demo3
{
    internal class MyCompareClass: IComparer<CBox>
    {
        public enum ESortType { Ascendinng, Descending }
        public ESortType SortType { get; set; }

        public MyCompareClass()
        {
            SortType = ESortType.Ascendinng;
        }
        public int Compare(CBox cbox1, CBox cbox2)
        {
            int result = 0;
            switch (SortType)
            {
                case ESortType.Ascendinng:
                    result = cbox1.CompareTo(cbox2);
                    break;
                case ESortType.Descending:
                    result = -1 * cbox1.CompareTo(cbox2);
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
