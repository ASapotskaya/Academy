using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Snake : Zoopark
    {
        public override void Eat()
        {
            Console.WriteLine("Змея ест");
        }

        public override void Sleep()
        {
            Console.WriteLine("Змея спит");
        }

        public override void Walk()
        {
            Console.WriteLine("Змея ползает");
        }
        public override string ToString()
        {
            return "Змеюка";
        }
    }
}
