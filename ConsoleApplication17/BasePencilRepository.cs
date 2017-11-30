using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication17
{
    abstract class BasePencilRepository: IPencilsRepository
    {
		protected Pencil[] _pencils;
		protected int Size { get; }

		public int Count => GetCount();

		public BasePencilRepository(int size)
        {
            Size = size;
			_pencils = new Pencil[size];
        }

		public Pencil this[int index]
		{
			get { return _pencils[index]; }
			set { _pencils[index] = value; }
		}

		public int GetCount()
		{
			int count = 0;

			foreach (var pencil in _pencils)
			{
				if (pencil != null )
					count++;
			}

			return count;
		}

		public abstract void Add(Pencil pencil);

        public abstract Pencil Get(int id);

      
		public void Delete(int index)
		{
			if (index < 0 || index > _pencils.Length - 1)
			{
				Console.WriteLine("Index is out of range");
				return;
			}

			for (int i = index; i < _pencils.Length; i++)
			{
				if (index == _pencils.Length - 1)
					return;

				_pencils[index] = _pencils[index + 1];
			}

			var newArr = new Pencil[_pencils.Length - 1];

		}

	
	}
}
