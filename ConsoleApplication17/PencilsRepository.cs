using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class PencilsRepository : BasePencilRepository
    {
       
        private int _lastIndex;

        public PencilsRepository(int size)
            :base(size)
        {
            _lastIndex = 0;
           
        }

      
        public override void Add(Pencil pencil)
        {
            _pencils[_lastIndex++] = pencil;
        }

        public override Pencil Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
