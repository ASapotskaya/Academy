using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standart_interface
{
    class Human : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{Name,-10} {Age,5}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //Human h1 = new Human { Name = "n1", Age = 20 };
            //Console.WriteLine(h1);
            ////Human h2 = h1; //адрес скопировали
            //Human h2 = (Human)h1.Clone();
            //Console.WriteLine(h2);
            //h1.Age = 200;
            //h2.Name = "N2";
            //Console.WriteLine("*******************************************");
            //Console.WriteLine(h1);
            //Console.WriteLine(h2);









            //Auditory auditory = new Auditory();
            //foreach (Student item in auditory)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("**************************************************************");
            //auditory.Sort();
            //foreach (Student item in auditory)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("**************************************************************");
            //auditory.Sort(new DateSort());
            //foreach (Student item in auditory)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("**************************************************************");
            //auditory.Sort(new SortStudCard());
            //foreach (Student item in auditory)
            //{
            //    Console.WriteLine(item);
            //}
            Student s1 = new Student { FirstName = "Ivan", LastName = "Ivanov", BD = new DateTime(2000, 1, 1), Card = new StudCard { Seria = "BB", Number = 12654 } };
            Student s2 = (Student)s1.Clone();
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            s2.FirstName = "JJ";
            s2.Card.Seria = "MM";
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}
