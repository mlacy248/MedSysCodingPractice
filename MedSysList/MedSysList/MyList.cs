using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedSysList
{
    public class MyList<T>
    {
        private List<T> _list;

        //Create
        public MyList()
        {
            _list = new List<T>();
        }
        public MyList(T value)
        {
            if (value == null) { throw new ArgumentNullException("value"); }

            _list = new List<T>()
            {
                value
            };
        }
        public MyList(List<T> list)
        {
            if(list == null) { throw new ArgumentNullException("list"); }

            _list = list;
        }

        //Delete
        public void Delete(T value)
        {
            if (value == null) { throw new ArgumentNullException("value"); }

            if (_list != null)
            {
                _list.Remove(value);
            }
        }

        //Add
        public void Add(T value)
        {
            if (value == null) { throw new ArgumentNullException("value"); }

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
