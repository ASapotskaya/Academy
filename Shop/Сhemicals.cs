using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public abstract class Сhemicals : Goods
    {
        string TypeOfChemicals { get; set; }
        public Сhemicals
            (
            int id, string name, double price, int amount,
            string typeofchemicals
            ) : base(id, name, price, amount)
        {
            TypeOfChemicals = typeofchemicals;
            //Console.WriteLine("CConstructor:\t" + GetHashCode());
        }
        public override void MenuPrint()
        {
            base.MenuPrint();
        }
        public override void Coming()
        {
            base.Coming();
            Console.Write("\nВведите тип бытовой химии: ");
            TypeOfChemicals = Console.ReadLine();
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
            Console.Write($" Тип бытовой химии: {TypeOfChemicals}.");
        }


    }
}
