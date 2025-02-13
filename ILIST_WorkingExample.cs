﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure_C_
{
    public class SimpleList<T> : IList<T>
    {
        private List<T> _items = new List<T>();


        public T this[int index]
        {
            get => _items[index];
            set => _items[index] = value;
        }


        public int Count => _items.Count;
        public bool IsReadOnly => false;


        public void Add(T item) => _items.Add(item);
        public void Clear() => _items.Clear();
        public bool Contains(T item) => _items.Contains(item);
        public void CopyTo(T[] array, int arrayIndex) => _items.CopyTo(array, arrayIndex);
        public IEnumerator<T> GetEnumerator() => _items.GetEnumerator();
        public int IndexOf(T item) => _items.IndexOf(item);
        public void Insert(int index, T item) => _items.Insert(index, item);
        public bool Remove(T item) => _items.Remove(item);
        public void RemoveAt(int index) => _items.RemoveAt(index);


        IEnumerator IEnumerable.GetEnumerator() => _items.GetEnumerator();
    }

    internal interface ILIST_WorkingExample
    {

    }
}
