using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
   

    
    public static class Program
    {
        //public delegate void MyDelegate();

     //   public event Action MyEvent;

    /*    static void HastTree(List<int> lists, MyDelegate someWork)
        {
            foreach(var item in lists)
            {
                if(item == 3)
                {
                    someWork();
                }
            }
        }*/

        static void MyMethod()
        {
            Console.WriteLine("Happened");
        }

        public static void Main(string[] args)
        {

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 46, 4, 5 };

          //  MyDelegate myFunction = MyMethod;

        //    HastTree(list, myFunction);
            
          //  TestClass.RewriteDelegate(ref MyMethod);

         //   HastTree(list, myFunction);

            list = new List<int> { 1, 2, 3, 4, 5 };

            List<int> newList = new List<int> { 4, 6, 3, 8 };

            list.Print();
            Console.WriteLine("++++++++++++++++++++");
            bool test1 = list.All(item => item % 2 == 0);
            Console.WriteLine("All item %  2 - " + test1);
            bool test2 = list.Any(item => item % 2 == 0);
            Console.WriteLine("Any item %  2 - " + test2);
            int test3 = list.Count(item => item % 2 == 0);
            Console.WriteLine("Count item %  2 - " + test3);
            int test4 = list.First(item => item % 2 == 0);
            Console.WriteLine("First item %  2 - " + test4);
            int test5 = list.FirstOrDefault(item => item % 9 == 0);
            Console.WriteLine("First item % 9 - " + test5);
            int test6 = list.LastOrDefault(item => item % 9 == 0);
            Console.WriteLine("LastOrDefault item % 9 - " + test6);

            Console.ReadKey();
        }


        public static bool All(this IEnumerable<int> list, Predicate<int> filter)
        {

            foreach(var item in list)
            {
                if (!filter(item))
                    return false;          
             }

            return true;
        }

        public static bool Any(this IEnumerable<int> list, Predicate<int> filter)
        {
           
            foreach(var item in list)
            {
                if(filter(item))
                    return true;
            }

            return false;
        }

        public static int Count(this IEnumerable<int> list, Predicate<int> filter)
        {
            int count = 0;

            foreach(var item in list)
            {
                if(filter(item))
                    count++;
            }

            return count;
        }


        public static int First(this IEnumerable<int> list, Predicate<int> filter)
        {
            foreach(var item in list)
            {
                if(filter(item))
                    return item;
            }

            throw new Exception ("Element is not found");
        }

        public static int FirstOrDefault(this IEnumerable<int> list, Predicate<int> filter)
        {
            foreach(var item in list)
            {
                if(filter(item))
                    return item;
            }

            return 0;
        }

        public static int Last(this IEnumerable<int> list, Predicate<int> filter)
        {
            int? last = null;

            foreach(var item in list)
            {
                if(filter(item))
                    last = item;
            }

            if(last == null)
                throw new Exception("Last element is not found");

            return (int)last;  
        }

        public static int LastOrDefault(this IEnumerable<int> list, Predicate<int> filter)
        {
            int? last = null;

            foreach(var item in list)
            {
                if(filter(item))
                    last = item;
            }

            if(last == null)
                return 0;

            return (int)last;
        }


    }
}
