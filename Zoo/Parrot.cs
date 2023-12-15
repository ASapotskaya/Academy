using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Parrot : Zoopark
    {
        public override void Eat()
        {
            Console.WriteLine("Попугай ест");
        }
        public override void Sleep()
        {
            Console.WriteLine("Попугай спит");
        }
        public override void Walk()
        {
            Console.WriteLine("Попугай летает");
        }
        public override string ToString()
        {
            return "Попуга";
        }
    }
}
