using System.Collections;
using System.Collections.Generic;

namespace Repka.Services
{
    public class MyList<T> : IMyList<T>
    {
        T[] array = null;
        public MyList()
        {
            array = new T[0];
        }
        public int Count
        {
            get { return array.Length; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void Add(T item)
        {
            T[] arr = new T[array.Length + 1];
            array.CopyTo(arr, 0);
            arr[array.Length] = item;
            array = arr;
        }
       
        public T this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
        int position = -1;
        public void Reset()
        {
            position = -1;
        }
        public IEnumerator<T> GetEnumerator()
        {
            while (true)
            {
                if (position < array.Length - 1)
                {
                    position++;
                    yield return array[position];
                }
                else
                {
                    Reset();
                    yield break;
                }
            }
        }
    }
}
