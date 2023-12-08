using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace Shop
{
    class Apple : Food , /*IGoods,*/ IEnumerable, IComparable
    {
       public String Variety { get; set; } // сорт яблоков 
                                           //List<IGoods> IGoods.List_goods { get; set; }

       Apple[] apples =
       {
            new Apple{Id = 1, Name = "Яблоко", Price = 254, Amount = 36, Variety = "Ранетки" },
            new Apple{Id = 2, Name = "Яблоко", Price = 352, Amount = 20, Variety = "Сочные" },
            new Apple{Id = 3, Name = "Яблоко", Price = 400, Amount = 18, Variety = "Красные" },
            new Apple{Id = 4, Name = "Яблоко", Price = 187, Amount = 10, Variety = "Зеленые" },
            new Apple{Id = 5, Name = "Яблоко", Price = 99, Amount = 9, Variety = "Желтые" },
            
        };
        public IEnumerator GetEnumerator()
        {
            return apples.GetEnumerator();
        }
        public int CompareTo(object obj)
        {
            if (obj is Apple)
            {
                return Id.CompareTo((obj as Apple).Id);

            }
            throw new NotImplementedException();
        }
        public void Sort()
        {
            Array.Sort(apples);
        }
        public override string ToString()
        {
            return $"{Id} {Name} {Price} {Amount} {Variety}"; // форматирование по правому краю, если хотим по левому краю - добавляем отрицательный знак

        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(apples, comparer);
        }
        public class VarietySort : IComparer
        {
            public int Compare(object x, object y)
            {
                if (x is Apple && y is Apple)
                {
                    
                        return ((Apple)x).Variety.CompareTo(((Apple)y).Variety);
                    
                }
                throw new NotImplementedException();
            }
        }







        //public override void Print()
        //{
        //    base.Print();
        //    Console.Write($" Сорт: {Variety}.");

        //}


        //    void IGoods.Coming()
        //    {


        //        Console.ForegroundColor = ConsoleColor.Green;

        //        Console.WriteLine("Поступление Яблок!");
        //        Console.ResetColor();
        //        Console.Write("\nВведите номер накладной: ");
        //        Id = Convert.ToInt32(Console.ReadLine());
        //        Console.Write("\nВведите наименование товара: ");
        //        Name = Console.ReadLine();
        //        Console.Write("\nВведите стоимость за 1 единицу товара: ");
        //        Price = Convert.ToInt32(Console.ReadLine());
        //        Console.Write("\nВведите количество товара: ");
        //        Amount = Convert.ToInt32(Console.ReadLine());
        //        Console.Write("\nВведите тип продуктов питания: ");
        //        TypeOfFood = Console.ReadLine();
        //        Console.Write("\nВведите сорт яблок: ");
        //        Variety = Console.ReadLine();

        //    }

        //    void IGoods.Selling()
        //    {


        //        Console.ForegroundColor = ConsoleColor.Green;

        //        Console.WriteLine("Продажа товара!");
        //        Console.ResetColor();

        //        Console.WriteLine("Введите количество товара на продажу: ");
        //        int amount1 = Convert.ToInt32(Console.ReadLine());
        //        if (amount1 > Amount) Console.WriteLine("Товара в таком количестве на складе нет.");
        //        else
        //        {
        //            if (amount1 == 0) Console.WriteLine("Вы ничего не выбрали.");
        //            else
        //            {
        //                Amount -= amount1;
        //                System.Threading.Thread.Sleep(500);
        //                Console.Beep();
        //                System.Threading.Thread.Sleep(1500);
        //                Console.WriteLine($"Сумма к оплате: {amount1 * Price}");
        //                System.Threading.Thread.Sleep(2000);
        //                Console.WriteLine($"Продажа прошла успешно. Остаток товара: {Amount} штук(а). Выручка: {amount1 * Price} руб.");
        //            }
        //        }

        //    }

        //    void IGoods.WriteOff()
        //    {


        //        Console.ForegroundColor = ConsoleColor.Green;

        //        Console.WriteLine("Списание товара!");
        //        Console.ResetColor();

        //        Console.WriteLine("Введите количество товара на списание: ");
        //        int amount2 = Convert.ToInt32(Console.ReadLine());
        //        if (amount2 > Amount) Console.WriteLine("Товара в таком количестве на складе нет.");
        //        else
        //        {
        //            if (amount2 == 0) Console.WriteLine("Вы ничего не выбрали.");
        //            else
        //            {
        //                Amount -= amount2;
        //                Console.WriteLine($"Товар в количестве {amount2} единиц выбыл. Остаток: {Amount} единиц. Убыток: {amount2 * Price} руб.");
        //            }
        //        }

        //    }
    }
}
