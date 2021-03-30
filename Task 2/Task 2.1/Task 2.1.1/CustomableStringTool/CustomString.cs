using System;

namespace CustomableStringTool
{

   public class CustomString : IComparable<CustomString>
    {
        private char[] _arr;

        public int Length
        {
            get { return _arr.Length; }
        }

        public CustomString(string inpString)
        {
            _arr = inpString.ToCharArray();
        }
        public CustomString(char[] inpString)
        {
            _arr = inpString;
        }

        public char this[int index]
        {
            get { return _arr[index]; }
            set
            {
                if (IsCorrectIndex(index))
                {
                    _arr[index] = value;
                }
            }
        }

        private bool IsCorrectIndex(int index)
        {
            if (index == 0 || index < _arr.Length)
            {
                throw new ArgumentException(); //
            }
            return true;
        }

        public int CompareTo(CustomString compareString)
        {
            if (Length != compareString.Length)
            {
                return -1;
            }
            else
            {
                for (int i = 0; i < Length; i++)
                {
                    if (_arr[i] > compareString[i])
                    {
                        return 1;
                    }
                    else if (_arr[i] < compareString[i])
                    {
                        return -1;
                    }
                }
                return 0;
            }
        }

        public static CustomString Concat(params CustomString[] strings)
        {
            int lengthOfArrays = 0;

            for (int i = 0; i < strings.Length; i++)
            {
                lengthOfArrays += strings[i].Length;
            }

            char[] tmpArr = new char[lengthOfArrays];
            int position = 0;

            for (int i = 0; i < strings.Length; i++)
            {
                strings[i]._arr.CopyTo(tmpArr, position);
                position += strings[i].Length;
            }

            return new CustomString(tmpArr);
        }

        public int IndexOf(char symbol)
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (_arr[i] == symbol)
                {
                    return _arr[i];
                }
            }
            return -1;
        }

        public int IndexOf(char symbol, int firstIndex, int lastindex)
        {
            if (IsCorrectIndex(firstIndex) && IsCorrectIndex(lastindex))
            {
                for (int i = 0; i < _arr.Length; i++)
                {
                    if (_arr[i] == symbol)
                    {
                        return _arr[i];
                    }
                }
            }
            return -1;
        }

        public char[] ToCharArray()
        {
            return _arr;
        }

        private bool IsConvertToInt()
        {
            for (int i = 0; i < _arr.Length; i++)
            {
                if (!char.IsNumber(_arr[i]))
                {
                    return false;
                }
            }
            return true;
        }
        public bool ToInt(out int returnedNumber)
        {
            int number = 0;
            if (IsConvertToInt())
            {
                for (int i = 0; i < _arr.Length; i++)
                {
                    number += (int)_arr[i];
                }
                returnedNumber = number;
                return true;
            }
            returnedNumber = default(int);
            return false;


        }

        public override string ToString()
        {
            return _arr.ToString();
        }
    }
}

