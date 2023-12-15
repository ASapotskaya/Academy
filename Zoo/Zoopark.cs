using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    abstract class Zoopark
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
       
        public abstract void Eat();
        public abstract void Sleep();
        public abstract void Walk();

        public void Info()
        {
            Console.WriteLine($"Информация: {Name}, Пол: {Gender}, Возраст: {Age} лет") ;
        }
        public abstract override string ToString();
    }
}
