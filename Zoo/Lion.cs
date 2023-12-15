using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Lion : Zoopark
    {
        public override void Eat()
        {
            Console.WriteLine("Лев ест");
        }
        public override void Sleep()
        {
            Console.WriteLine("Лев спит");
        }
        public override void Walk()
        {
            Console.WriteLine("Лев гуляет");
        }
        public override string ToString()
        {
            return "Лев";
        }
    }
}
