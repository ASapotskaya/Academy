using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Shop
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.Title = "Shop";

            Apple apple = new Apple();
            BrefActive bref = new BrefActive();
        
            Goods[] gooods = { bref, apple };

            Console.WriteLine("Выберите товар");
            Console.WriteLine("1. БрэфЭктив. ");
            Console.WriteLine("2. Яблоко. ");
            int number = Convert.ToInt32(Console.ReadLine());
            switch(number)
            {
                case 1: gooods[0].MenuPrint(); break;
                case 2: gooods[1].MenuPrint(); break;
            }
        }
    }
}
