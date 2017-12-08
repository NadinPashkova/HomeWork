using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
	class MyGenericList<T> : IEnumerable<T>
	{
		private T[] _array;

		public MyGenericList(T[] array)
		{
			_array = array;
		}


		public IEnumerator<T> GetEnumerator()
		{
			return new MyGenericListEnumerator(_array);

		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			throw new NotImplementedException();
		}

		
		private class MyGenericListEnumerator : IEnumerator<T>
		{
			private T[] _array;
				private int _index;
			public T Current => _array[_index];

			object IEnumerator.Current => _array[_index];
			

			public MyGenericListEnumerator(T[] array)
			{
				_array = array;
			}

			public void Dispose()
			{

			}

			public void Reset()
			{

			}

			public bool MoveNext()
			{
				_index++;
				return _index > _array.Length;
			}
		}


	}
}
