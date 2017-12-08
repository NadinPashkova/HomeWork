using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{



    public class FileManager
    {
  

        public delegate void FileFoundHandler();

        private event FileFoundHandler _fileFounder;

        public event FileFoundHandler FileFound
        {
            add
            {

                if (_fileFounder == null || _fileFounder.GetInvocationList().Length < 2)
                 _fileFounder += value;

            }
            remove { _fileFounder -= value; }
        }



        public void Search(bool isFound) {

            if(isFound)
            {
                OnFileFound();
            }

        }

        protected virtual void OnFileFound()
        {

            _fileFounder?.Invoke();

       }

    }
}
