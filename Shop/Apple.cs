using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Shop
{
    class Apple : Food
    {
        String Variety { get; set; } // сорт яблоков 
        public Apple
            (int id = 0, string name = "", double price = 0, int amount = 0, string typeoffood = "",
            string variety = ""
            ) : base(id, name, price, amount, typeoffood)
        {
            Variety = variety;
            //Console.WriteLine("AConstructor:\t" + GetHashCode());
        }
        public override void MenuPrint()
        {
           
            base.MenuPrint();
            
        }
        public override void Coming()
        {
            Console.Clear();
            Console.SetCursorPosition(32, 1);
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Поступление Яблок!");
            Console.ResetColor();
            base.Coming();
            Console.Write("\nВведите сорт яблок: ");
            Variety = Console.ReadLine();
            Console.WriteLine("Вернуться в меню: клавиша M ");
        }
        public override void Selling()
        {
            base.Selling();
        }
        public override void WriteOff()
        {
            base.WriteOff();
        }
        public override void Print()
        {
            base.Print();
            Console.Write($" Сорт: {Variety}.");
            Console.WriteLine("\nВернуться в меню: клавиша M ");
        }
    }
}
