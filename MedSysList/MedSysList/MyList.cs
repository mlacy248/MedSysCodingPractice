using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSysList
{
    internal class MyList<T>
    {
        private List<T> _list;

        //Create
        public MyList()
        {
            _list = new List<T>();
        }
        public MyList(T value)
        {
            _list = new List<T>()
            {
                value
            };
        }
        public MyList(List<T> list)
        {
            _list = list;
        }

        //Delete
        public void Delete(T value)
        {
            if (_list != null)
            {
                _list.Remove(value);
            }
        }

        //Add
        public void Add(T value)
        {
            _list.Add(value);
        }

        //Read Value
        public T ReadValueAtIndex(int index)
        {
            return _list[index];
        }

        //Read List
        public List<T> ReadList() 
        {
            return _list;
        }
    }
}
