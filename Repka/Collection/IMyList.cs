using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Repka.Services
{
    interface IMyList<T> : IEnumerable<T>
    {
        public void Add(T item);
       // public void Clear();
       // public bool Remove(T item);
        public int Count { get; }
        public T this [int index]{ get; set;}
    }
}
