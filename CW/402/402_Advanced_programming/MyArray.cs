using System;

namespace _402_Advanced_programming
{
    class MyArray
    {
        private readonly int[] _arr;
        public int Length;

        public MyArray(int size)
        {
            _arr = new int[size];
            Length = size;
        }

        public int this[int index]
        {
            get
            {
                return _arr[index];
            }

            set
            {
                _arr[index] = value;
            }
        }

        // Перегружаем индексатор
        public int this[double index]
        {
            get
            {
                return _arr[(int)Math.Round(index)];
            }

            set
            {
                _arr[(int)Math.Round(index)] = value;
            }
        }
    }
}