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
        public string TypeOfFood { get; set; }
        //public List<IGoods> List_goods { get; set; }

       
        
        public override void Print()
        {

            base.Print();
            Console.Write($" Тип продуктов питания: {TypeOfFood}.");
        }




    }
}
