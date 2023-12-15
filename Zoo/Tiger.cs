using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    class Tiger : Zoopark
    {

        public override void Eat()
        {
            Console.WriteLine("Тигр ест");
        }

        public override void Sleep()
        {
            Console.WriteLine("Тигр спит");
        }

        public override void Walk()
        {
            Console.WriteLine("Тигр гуляет");
        }
        public override string ToString()
        {
            return "Тигорь";
        }
    }
}
