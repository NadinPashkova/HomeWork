using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{

    class Program
    {
        static void Main(string[] args)
        {
           var pencilsRepository = new PencilsRepository(24);
                       
            var pencil = new Pencil
            {
                Id = 0,
                Brand = "Marc",
                Price = 25,
                Size = 25
            };

            pencilsRepository.Add(pencil);
            pencilsRepository.Print(pencil);
            Console.ReadKey();
        }
    }
}
