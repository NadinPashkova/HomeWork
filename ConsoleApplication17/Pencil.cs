using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class Pencil
    {
        public int Id { get; set; }

        public int Size { get; set; }

        public string Brand { get; set; }

        public double Price { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}\n{nameof(Brand)}: {Brand}\n{nameof(Price)}: {Price}\n";
        }
    }
}
