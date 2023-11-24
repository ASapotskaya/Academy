using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Shop
{
    class BrefActive : Сhemicals
    {
        string Area { get; set; }
        public BrefActive
            (int id = 0, string name = "", double price = 0, int amount = 0, string typeofchemicals = "",
            string area = ""
            ) : base(id, name, price, amount, typeofchemicals)
        {
            Area = area;
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

            Console.WriteLine("Поступление БрэфЭктив!");
            Console.ResetColor();
            base.Coming();
            Console.Write("\nВведите область применения Брэфа: ");
            Area = Console.ReadLine();
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
            Console.Write($" Область применения: {Area}.");
            Console.WriteLine("Вернуться в меню: клавиша M ");
        }
    }
}
