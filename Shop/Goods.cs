using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Shop
{
    public abstract class Goods
    {
        protected int Id { get; set; }
        protected string Name { get; set; }
        protected double Price { get; set; }
        protected int Amount { get; set; }
        public Goods(int id = 0, string name = "", double price = 0, int amount=0)
        {
            Id = id;
            Name = name;
            Price = price;
            Amount = amount;
            //Console.WriteLine("GConstructor:\t" + GetHashCode());
        }
        public virtual void Coming()
        {
            
           
            Console.SetCursorPosition(20, 3);
            Console.WriteLine("\nВведите номер накладной: ");
                Id = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nВведите наименование товара: ");
                Name = Console.ReadLine();
                Console.Write("\nВведите стоимость за 1 единицу товара: ");
                Price = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nВведите количество товара: ");
                Amount = Convert.ToInt32(Console.ReadLine());
            
        }
        public virtual void Selling()
        {
            Console.Clear();
            Console.WriteLine("Введите количество товара на продажу: ");
            int amount1 = Convert.ToInt32(Console.ReadLine());
            if (amount1 > Amount) Console.WriteLine("Товара в таком количестве на складе нет.");
            if (amount1 == 0) Console.WriteLine("Вы ничего не выбрали.");
            else
            {
                Amount -= amount1;
            }
            Console.WriteLine($"Продажа прошла успешно. Остаток: {Amount} штук(а).");
            Console.WriteLine("Вернуться в меню: клавиша M ");
        }

        internal void MenuPrint()
        {
            Console.Clear();
            Console.SetCursorPosition(32, 1);
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Добро пожаловать в магазин!");
            Console.ResetColor();
            Console.SetCursorPosition(20, 3);
            Console.WriteLine("Выберите операцию: ");
            Console.WriteLine("1.Поступление товара.");
            Console.WriteLine("2.Продажа.");
            Console.WriteLine("3.Выбытие.");
            Console.WriteLine("4.Наличие.");
            Console.WriteLine("Клавиша Esc - выход из программы.");

            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                switch (key)
                {
                    case ConsoleKey.D1: Coming(); break;
                    case ConsoleKey.D2: Selling(); break;
                    case ConsoleKey.D3: WriteOff(); break;
                    case ConsoleKey.D4: Print(); break;
                    case ConsoleKey.Escape: Console.WriteLine("Выход"); break;
                    case ConsoleKey.M: MenuPrint(); break;
                    default: Console.WriteLine("Error"); break;
                }
            } while (key != ConsoleKey.Escape);

        }

        public virtual void WriteOff()
        {
            Console.Clear();
            Console.WriteLine("Введите количество товара на списание: ");
            int amount2 = Convert.ToInt32(Console.ReadLine());
            if (amount2 > Amount) Console.WriteLine("Товара в таком количестве на складе нет.");
            if (amount2 == 0) Console.WriteLine("Вы ничего не выбрали.");
            else
            {
                Amount -= amount2;
            }
            Console.WriteLine("Вернуться в меню: клавиша M ");

        }
         public virtual void Print()
        {
            
            Console.WriteLine($"Номер накладной: {Id}.\tНаименование товара: {Name}.\tЦена за 1 единицу/кг: {Price} руб.\t Количество товара в наличии: {Amount}.");
            
        }

        

    }
}
