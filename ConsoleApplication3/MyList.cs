using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication3
{
	public class MyList : IEnumerable, IEnumerator
	{ 
		private string[] _array;
		private int _index;

		public MyList(string[] array)
		{
			_array = array;

		}

		public void Reset()
		{
			_index = -1;
		}


		public object Current
		{
			get
			{
				return _array[_index];
			}
		}

		public bool MoveNext()
		{
			_index++;
			return _index < _array.Length;
		}



		public IEnumerator GetEnumerator()
		{
			return null;
		}

		
		public class MyListEnumerator : IEnumerator
		{
			private string[] _array;
			private int _index = -1;

			public MyListEnumerator(string[] array)
			{

				_array = array;
			}

			public object Current
			{
				get
				{
					return _array[_index];
				}
			}

			public bool MoveNext()
			{
				_index++;
				return _index < _array.Length;
			}


			public void Reset()
			{
				_index = -1;
			}
		
		}

	}
}
