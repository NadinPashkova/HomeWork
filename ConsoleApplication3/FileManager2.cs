using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
	class Point : IComparable 
	{
		int _x;

		int _y;


		public Point(int x)
		{
			_x = x;
		}




		public int CompareTo(object obj)
		{
			Point p = obj as Point; //not parse - null

			//var b = obj is Point; //return bool, if object has this type

			if(p != null)
			{
				if(p._x == _x)
					return 0;
				else if(p._x > _x)
					return 1;

				return -1;

			}
			else
			{
				throw new ArgumentException("Exc");
			}


		}
	  
	}
}
