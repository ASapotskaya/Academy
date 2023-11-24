using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Shop
{
    public abstract class Food : Goods
    {
        protected string TypeOfFood { get; set; }
        public Food
            (
            int id =0, string name = "", double price = 0, int amount = 0,
            string typeoffood = ""
            ):base(id, name, price, amount)
        {
            TypeOfFood = typeoffood;
            //Console.WriteLine("FConstructor:\t" + GetHashCode());
        }
        public override void MenuPrint()
        {
            base.MenuPrint();
        }
        public override void Coming()
        {
            base.Coming();
            Console.Write("\nВведите тип продуктов питания: ");
            TypeOfFood = Console.ReadLine();
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
            Console.Write($" Тип продуктов питания: {TypeOfFood}.");  
        }



    }
}
