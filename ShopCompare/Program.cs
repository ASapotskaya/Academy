using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCompare
{
    class Program
    {
        static void Main(string[] args)
        {

            Shop shop = new Shop();
            foreach (Apple item in shop)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************************************************************");
            shop.Sort();
            foreach (Apple item in shop)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************************************************************");
            shop.Sort(new SortVariety());
            foreach (Apple item in shop)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**************************************************************");
        }
    }
}
