using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Shop
{
    class BrefActive : Сhemicals, IGoods
    {
        string Area { get; set; }

       // public List<IGoods> List_goods { get; set; }
        
       
        void IGoods.Coming()
        {
            
            
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Поступление БрэфЭктив!");
            Console.ResetColor();
            
            Console.Write("\nВведите номер накладной: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите наименование товара: ");
            Name = Console.ReadLine();
            Console.Write("\nВведите стоимость за 1 единицу товара: ");
            Price = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите количество товара: ");
            Amount = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nВведите тип бытовой химии: ");
            TypeOfChemicals = Console.ReadLine();
            Console.Write("\nВведите область применения Брэфа: ");
            Area = Console.ReadLine();
            
        }
        public override void Print()
        {
            base.Print();
            Console.Write($" Область применения: {Area}.");
            
        }

        public void Selling()
        {
            
           
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Продажа товара!");
            Console.ResetColor();
            
            Console.WriteLine("Введите количество товара на продажу: ");
            int amount1 = Convert.ToInt32(Console.ReadLine());
            if (amount1 > Amount) Console.WriteLine("Товара в таком количестве на складе нет.");
            else
            {
                if (amount1 == 0) Console.WriteLine("Вы ничего не выбрали.");
                else
                {
                    Amount -= amount1;
                    System.Threading.Thread.Sleep(500);
                    Console.Beep();
                    System.Threading.Thread.Sleep(1500);
                    Console.WriteLine($"Сумма к оплате: {amount1 * Price}");
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine($"Продажа прошла успешно. Остаток товара: {Amount} штук(а). Выручка: {amount1 * Price} руб.");
                }
            }
            
        }

        public void WriteOff()
        {
            
            
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Списание товара!");
            Console.ResetColor();
           
            Console.WriteLine("Введите количество товара на списание: ");
            int amount2 = Convert.ToInt32(Console.ReadLine());
            if (amount2 > Amount) Console.WriteLine("Товара в таком количестве на складе нет.");
            else
            {
                if (amount2 == 0) Console.WriteLine("Вы ничего не выбрали.");
                else
                {
                    Amount -= amount2;
                    Console.WriteLine($"Товар в количестве {amount2} единиц выбыл. Остаток: {Amount} единиц. Убыток: {amount2 * Price} руб.");
                }
            }
            
        }
    }
}
