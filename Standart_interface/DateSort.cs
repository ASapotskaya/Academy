using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standart_interface
{
    class DateSort : IComparer
    {
        public int Compare(object x, object y)
        {
            if(x is Student && y is Student)
            {
                return DateTime.Compare((x as Student).BD, (y as Student).BD);
            }
            throw new NotImplementedException();
        }
    }
}
