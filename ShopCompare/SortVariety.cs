using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCompare
{
    class SortVariety : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Apple && y is Apple)
            {

                return ((Apple)x).Variety.CompareTo(((Apple)y).Variety);

            }
            throw new NotImplementedException();
        }
    }
}
