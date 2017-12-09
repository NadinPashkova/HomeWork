using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
	class DictionaryGeneric<T,U> : IEnumerable<KeyValuePair<T,U>>
	{
		private KeyValuePair<T, U>[] _dictionary;


		public DictionaryGeneric(KeyValuePair<T, U> [] dictionary)
		{
			_dictionary = dictionary;
		}

		public IEnumerator<KeyValuePair<T, U>> GetEnumerator()
		{
			return new MyGenericListEnumerator(_dictionary);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new MyGenericListEnumerator(_dictionary);
		}

		private class MyGenericListEnumerator : IEnumerator<KeyValuePair<T, U>>
		{
			private KeyValuePair<T, U>[] _dictionary;

			private int _index = -1;

			public MyGenericListEnumerator(KeyValuePair<T, U>[] dictionary)
			{
				_dictionary = dictionary;
			}

			public KeyValuePair<T, U> Current
			{
				get
				{
					return _dictionary[_index];
				}
			}

			object IEnumerator.Current
			{
				get
				{
					return _dictionary[_index];
				}
			}

			public void Dispose()
			{
				_dictionary = new KeyValuePair<T, U>[] { };
			}

			public bool MoveNext()
			{
				_index++;

				return _index < _dictionary.Length;
			}

			public void Reset()
			{
				_index = -1;
			}
		}
	}
}
