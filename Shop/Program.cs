using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Shop
{
    public interface IGoods
    {
        //List<IGoods> List_goods { get; set; }

        void Coming();
        void Selling();
        void WriteOff();
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "Shop";

            Apple apple = new Apple();
            //BrefActive bref = new BrefActive();
            //Goods[] gooods = { bref, apple };


            //apple.List_goods = new List<IGoods>
            //{
            //    new Apple(), new Apple()
            //};


            //foreach (IGoods item in apple.List_goods)
            //{

            //    Console.ForegroundColor = ConsoleColor.Green;

            //    Console.WriteLine("Добро пожаловать в магазин!");
            //    Console.ResetColor();

            //    Console.WriteLine("Выберите операцию: ");
            //    Console.WriteLine("1.Поступление товара.");
            //    Console.WriteLine("2.Продажа.");
            //    Console.WriteLine("3.Выбытие.");
            //    Console.WriteLine("Клавиша Esc - выход из программы.");

            //    ConsoleKey key;
            //    do
            //    {
            //        key = Console.ReadKey(true).Key;
            //        switch (key)
            //        {
            //            case ConsoleKey.D1: item.Coming(); break;
            //            case ConsoleKey.D2: item.Selling(); break;
            //            case ConsoleKey.D3: item.WriteOff(); break;
            //            case ConsoleKey.Escape: Console.WriteLine("Выход"); break;

            //            default: Console.WriteLine("Error"); break;
            //        }
            //    } while (key != ConsoleKey.Escape);



            foreach (Apple item in apple)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************************************************************");
            apple.Sort();
            foreach (Apple item in apple)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************************************************************");
            apple.Sort(new Apple.VarietySort());
            foreach (Apple item in apple)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************************************************************");
            //apple.Sort(new SortStudCard());
            //foreach (Student item in auditory)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }   
    
}
