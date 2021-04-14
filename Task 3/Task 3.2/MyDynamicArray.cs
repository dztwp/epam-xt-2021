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

        public int Count => _length;//Legth поменять

        public bool IsReadOnly => false;


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
            _arr[Count] = newElementOfArray;
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
                T[]tmpArr = _arr.Where(s => !s.Equals(item)).ToArray();
                _length = tmpArr.Length;
                Array.Clear(_arr, 0, _arr.Length);
                Array.Copy(tmpArr,_arr,Count);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Insert(T item, int position)
        {

            if (position >= Capacity || position < 0)
            {
                return false;
            }

            if (IsNeedToResize(1))
            {
                ResizeArr(2);
            }
            for (int i = _arr.Length-2; i > 0; i--)
            {
                if (position == i)
                {
                    _arr[i] = item;
                    break;
                }
                else
                {
                    _arr[i + 1] = _arr[i];
                }
            }
            _length++;
            return true;

        }

        public void Clear() => Array.Clear(_arr, 0, Count);

        public bool Contains(T item) => _arr.Contains(item) ? true : false;

        public void CopyTo(T[] array, int arrayIndex) => _arr.CopyTo(array, arrayIndex);

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _arr[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => _arr.GetEnumerator();

        public T this[int index]
        {

            get
            {
                return (index < Count && index > 0) ? _arr[index] : throw new ArgumentOutOfRangeException();
            }

            set
            {
                _arr[index] = (index < Count && index > 0) ? value : throw new ArgumentOutOfRangeException();
            }
        }


        private bool IsNeedToResize(int sizeOfArr) => (Capacity - Count >= sizeOfArr) ? true : false;

        private void ResizeArr(int multiply) => Array.Resize<T>(ref _arr, Capacity * multiply);

        private int GetMultiply(int countOfNewArr)
        {
            int i = 2;
            while (true)
            {
                if (countOfNewArr + Count < Capacity * i)
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
