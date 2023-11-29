using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Shop
{
    public abstract class Сhemicals : Goods
    {
        protected string TypeOfChemicals { get; set; }
       
       
        
        public override void Print()
        {
            base.Print();
            Console.Clear();
            Console.Write($" Тип бытовой химии: {TypeOfChemicals}.");
        }




    }
}
