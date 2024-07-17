using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class CustomList<T>
    {
        private T[] _items;
        private int _size;
        private int _capacity;

        public CustomList()
        {
            _capacity = 4;
            _items = new T[_capacity];
            _size = 0;
        }

        public void Add(T item)
        {
            if (_size == _capacity)
            {
                _capacity *= 2;
                T[] newItems = new T[_capacity];
                for (int i = 0; i < _size; i++)
                {
                    newItems[i] = _items[i];
                }
                _items = newItems;
            }
            _items[_size] = item;
            _size++;
        }

        public T Find(T item)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_items[i].Equals(item))
                {
                    return _items[i];
                }
            }
            return default(T);
        }

        public List<T> FindAll(T item)
        {
            List<T> result = new List<T>();
            for (int i = 0; i < _size; i++)
            {
                if (_items[i].Equals(item))
                {
                    result.Add(_items[i]);
                }
            }
            return result;
        }

        public void Remove(T item)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_items[i].Equals(item))
                {
                    for (int j = i; j < _size - 1; j++)
                    {
                        _items[j] = _items[j + 1];
                    }
                    Array.Resize(ref _items, --_size);
                    return;
                }
            }
            Console.WriteLine("bele bir element yoxdur!");
        }

        public void RemoveAll(T item)
        {
            bool isRemoved = false;
            for (int i = 0; i < _size; i++)
            {
                if (_items[i].Equals(item))
                {
                    isRemoved = true;
                    Remove(_items[i]);
                }
            }
            if (!isRemoved) Console.WriteLine("bele element yoxdur!");
        }

        public int Count => _size;
        public T this[int index]
        {
            get=> _items[index];
            set
            {
                _items[index] = value;
            }
            
        }

    }
}

