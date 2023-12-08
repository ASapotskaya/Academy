using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCompare
{
    class Shop : IEnumerable
    {

        Apple[] apples =
       {
            new Apple{Id = 1, Name = "Яблоко", Price = 254, Amount = 36, Variety = "Ранетки" },
            new Apple{Id = 3, Name = "Яблоко", Price = 352, Amount = 20, Variety = "Сочные" },
            new Apple{Id = 2, Name = "Яблоко", Price = 400, Amount = 18, Variety = "Красные" },
            new Apple{Id = 5, Name = "Яблоко", Price = 187, Amount = 10, Variety = "Зеленые" },
            new Apple{Id = 4, Name = "Яблоко", Price = 99, Amount = 9, Variety = "Желтые" },

        };
        public IEnumerator GetEnumerator()
        {
            return apples.GetEnumerator();
        }
        public void Sort()
        {
            Array.Sort(apples);
        }
        public void Sort(IComparer comparer)
        {
            Array.Sort(apples, comparer);
        }
    }
}
