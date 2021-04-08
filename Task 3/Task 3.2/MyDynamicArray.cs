using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._2
{
    class MyDynamicArray<T> : ICollection<T>
    {
        T[] _arr;

        private int _length;

        public int Count => Capacity;

        public bool IsReadOnly => false;

        public int Length => _length;

        public int Capacity => _arr.Length;

        public MyDynamicArray()
        {
            _arr = new T[8];
            _length = 0;

        }
        public MyDynamicArray(int arrSize)
        {
            _arr = new T[arrSize];
            _length = 0;
        }
        public MyDynamicArray(IEnumerable<T> inCollection)
        {
            _arr = inCollection.ToArray();
            _length = _arr.Length;
        }

        public void Add(T newElementOfArray)
        {
            if (IsNeedToResize(1))
            {
                ResizeArr(2);
            }
            _length++;
            _arr[Length] = newElementOfArray;
        }

        public void AddRange(IEnumerable<T> newValues)
        {
            if (IsNeedToResize(newValues.Count()))
            {
                ResizeArr(GetMultiply(newValues.Count()));
            }

            _length += newValues.Count();
            _arr = _arr.Concat(newValues).ToArray();

        }

        public bool Remove(T item)
        {
            if (_arr.Contains(item))
            {
                _arr = _arr.Where(s => !s.Equals(item)).ToArray();
                Array.Resize(ref _arr, Length);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Insert(T item, int position)
        {
            try
            {
                if (position >= Capacity || position < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }                
            }
            catch (ArgumentOutOfRangeException)
            {
                return false;
            }

            if (IsNeedToResize(1))
            {
                ResizeArr(2);
            }
            List<T> tmpList = new List<T>();
            for (int i = 0; i < _arr.Length; i++)
            {
                if (position == i)
                {
                    tmpList.Add(item);
                }
                else
                {
                    tmpList.Add(_arr[i]);
                }
            }
            _arr = tmpList.ToArray();
            _length++;
            return true;

        }

        public void Clear() => Array.Clear(_arr, 0, Length);

        public bool Contains(T item) => _arr.Contains(item) ? true : false;

        public void CopyTo(T[] array, int arrayIndex)=> _arr.CopyTo(array, arrayIndex);

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Length; i++)
            {
                yield return _arr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => _arr.GetEnumerator();

        public T this[int index]
        {

            get
            {
                return (index > Length)? _arr[index]:throw new ArgumentOutOfRangeException();
            }

            set
            {
                _arr[index]= (index > Length) ?  value : throw new ArgumentOutOfRangeException();
            }
        }


        private bool IsNeedToResize(int sizeOfArr) => (Capacity - Length >= sizeOfArr) ? true : false;

        private void ResizeArr(int multiply) => Array.Resize<T>(ref _arr, Capacity * multiply);

        private int GetMultiply(int countOfNewArr)
        {
            int i = 2;
            while (true)
            {
                if (countOfNewArr + Length < Capacity * i)
                {
                    return i;
                }
                else
                {
                    i *= 2;
                }
            }
        }

    }
}
