using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public static class IEnumerableExtension
    {
        public static void Print(this List<int> list)
        {
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }

        /*
        public static List<int> Filter(this IEnumerable<int> list)
        {
            List<int> newlist = new List<int>();

            foreach(var item in list)
            {
                if(item % 2 == 0)
                    newlist.Add(item);
            }

            return newlist;
        }

        public static List<int> FilterCommon(this IEnumerable<int> list, List<int> newList)
        {
            List<int> commonlist = new List<int>();

            foreach(var item in list)
            {
                if(newList.Contains(item))
                    commonlist.Add(item);
            }
      

            return commonlist;
        }
        */




    }
}
