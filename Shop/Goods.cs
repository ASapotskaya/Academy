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

        public virtual void Print()
        {
            Console.Clear();
            Console.Write($"Номер накладной: {Id}.\tНаименование товара: {Name}.\tЦена за 1 единицу/кг: {Price} руб.\t Количество товара в наличии: {Amount}.");
        }




    }
}
