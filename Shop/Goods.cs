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
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }

        public virtual void Print()
        {
            Console.Clear();
            Console.Write($"Номер накладной: {Id}.\tНаименование товара: {Name}.\tЦена за 1 единицу/кг: {Price} руб.\t Количество товара в наличии: {Amount}.");
        }




    }
}
