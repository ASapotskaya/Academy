using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standart_interface
{
    class Student:IComparable, ICloneable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime BD { get; set; }

        public StudCard Card { get; set; }

        public object Clone()
        {
            Student temp = (Student)this.MemberwiseClone();
            temp.Card = new StudCard
            {
                Seria = this.Card.Seria,
                Number = this.Card.Number
            };
            return temp;
        }

        public int CompareTo(object obj)
        {
            if (obj is Student)
            {
                return LastName.CompareTo((obj as Student).LastName);

            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{FirstName, -15} {LastName,15} {BD.ToShortDateString(), 17} {Card,10}"; // форматирование по правому краю, если хотим по левому краю - добавляем отрицательный знак

        }
       
    }
}
