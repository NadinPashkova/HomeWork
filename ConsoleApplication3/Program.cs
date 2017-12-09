using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {


			DictionaryGeneric<string, int> dictionaryList = new DictionaryGeneric<string, int>(new []
			{
				new KeyValuePair<string, int> ( "first", 1 ),
				new KeyValuePair<string, int> ( "second", 1 ),
				new KeyValuePair<string, int> ( "serd", 1 ),
			}
			 );

			foreach (var pair in dictionaryList)
			{
				Console.WriteLine(pair.Key);
			}

		}





		
    }
}
