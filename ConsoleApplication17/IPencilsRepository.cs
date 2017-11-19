using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    interface IPencilsRepository
    {
        Pencil this[int index] { get; }
        int Count { get; }
        void Delete(int index);
    }
}
