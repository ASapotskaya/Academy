using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCompare
{
    class Apple : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public String Variety { get; set; }

        public int CompareTo(object obj)
        {
            if (obj is Apple)
            {
                return Id.CompareTo((obj as Apple).Id);

            }
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"{Id, -5} {Name, -10} {Price, -5} {Amount, -5} {Variety,-17}"; // форматирование по правому краю, если хотим по левому краю - добавляем отрицательный знак

        }
       
    }
}
