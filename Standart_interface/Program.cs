using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standart_interface
{
    class Program
    {


        static void Main(string[] args)
        {
            Auditory auditory = new Auditory();
            foreach (Student item in auditory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************************************************************");
            auditory.Sort();
            foreach (Student item in auditory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************************************************************");
            auditory.Sort(new DateSort());
            foreach (Student item in auditory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************************************************************");
            auditory.Sort(new SortStudCard());
            foreach (Student item in auditory)
            {
                Console.WriteLine(item);
            }
        }
    }
}
