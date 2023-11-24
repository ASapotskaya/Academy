using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Shop
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.Title = "Shop";
            
            //Console.SetCursorPosition(35, 3);
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.WriteLine("Выберите операцию: ");
            //Console.SetCursorPosition(35, 5);
            //Console.WriteLine("1.Поступление товара.");
            //Console.SetCursorPosition(35, 6);
            //Console.WriteLine("2.Продажа.");
            //Console.SetCursorPosition(35, 7);
            //Console.WriteLine("3.Выбытие.");
            //Console.SetCursorPosition(35, 8);
            //Console.WriteLine("Клавиша Esc - выход из программы.");
            //Console.ResetColor();

            Goods[] gooods = { new Apple(), new BrefActive()};
            foreach (Goods item in gooods)
                {
                   item.MenuPrint();
                }
                
              


        }
    }
}
