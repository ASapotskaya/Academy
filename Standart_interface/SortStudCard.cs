using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standart_interface
{
    class SortStudCard : IComparer
    {
        public int Compare(object x, object y)
        {
            if (x is Student && y is Student)
            {
                int Seria_Card = ((Student)x).Card.Seria.CompareTo(((Student)y).Card.Seria);
                if (Seria_Card == 0)
                {
                    return ((Student)x).Card.Number.CompareTo(((Student)y).Card.Number);
                }
                else return Seria_Card;
                //return StudCard.Compare((x as Student).Card, (y as Student).Card);
            }
            throw new NotImplementedException();
        }
    }
}
