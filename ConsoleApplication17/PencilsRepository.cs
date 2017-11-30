using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace ConsoleApplication17
{
    class PencilsRepository : BasePencilRepository
    {
		private const string _filePath = "\\pencils.xml";

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

		public void WriteToFile()
		{
			var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + _filePath;

			XmlSerializer serializer = new XmlSerializer(typeof(Pencil[]));

			using (StreamWriter writer = new StreamWriter(path))
			{
				serializer.Serialize(writer, _pencils);
			}
		}

		public Pencil[] ReadFromFile()
		{
			var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + _filePath;

			using (var reader = new StreamReader(path))
			{
				XmlSerializer deserializer = new XmlSerializer(typeof(Pencil[]));
				return (Pencil[])deserializer.Deserialize(reader);
			}
		}
	}
}
