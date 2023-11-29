using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standart_interface
{
    class Auditory: IEnumerable
    {
         Student[] students =
        {
            new Student{FirstName = "Ivan", LastName = "Ivanov", BD = new DateTime(2000,1,1), Card = new StudCard{Seria="BB",Number=12654}},
            new Student{FirstName = "Sasha", LastName = "Sapotskaya", BD = new DateTime(1999,2,24), Card = new StudCard{Seria="AB",Number=13652}},
            new Student{FirstName = "Kristina", LastName = "Karapetyan", BD = new DateTime(1998,10,21), Card = new StudCard{Seria="KK",Number=12254}},
            new Student{FirstName = "Inna", LastName = "Vodolagina", BD = new DateTime(1997,5,27), Card = new StudCard{Seria="IV",Number=14564}},
            new Student{FirstName = "Vsevolod", LastName = "Zakrevskii", BD = new DateTime(2004,5,26), Card = new StudCard{Seria="VZ",Number=17854}},
        };

       IEnumerator IEnumerable.GetEnumerator()
        {
            return students.GetEnumerator();
        }
        public void Sort()
        {
            Array.Sort(students);
        }
        public void Sort(IComparer comparer)
        {
            Array.Sort(students, comparer);
        }
        
    }
}
