using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standart_interface
{
    class StudCard
    {
        public int Number { get; set; }
        public string Seria { get; set; }
        public override string ToString()
        {
            return $"{Seria} {Number}";
        }
    }
}
