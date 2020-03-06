using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Repka.Services
{
    interface IMyList<T> : IEnumerable<T>
    {
        void AddToLast(T value);
        void AddToFirst(T value);
        void Add(T value);
        void RemoveFirst();
        void RemoveLast();
        bool Remove(T value);
        void Clear();
    }
}
