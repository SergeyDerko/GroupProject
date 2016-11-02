using System;
using System.Collections.Generic;

namespace _402_Advanced_programming
{
    class Calendar
    {
        private readonly Dictionary<string, int> _arr;
        private int _length;

        public int Length
        {
            get { return _arr.Count; }
        }

        public Calendar()
        {
            _arr = new Dictionary<string, int>();
        }

        public Calendar(int i)
        {
            
        }

        public int this[string index]
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
        //public int this[double index]
        //{
        //    get
        //    {
        //        return _arr[(int)Math.Round(index)];
        //    }

        //    set
        //    {
        //        _arr[(int)Math.Round(index)] = value;
        //    }
        //}
        public void Add(string key, int value)
        {
            _arr.Add(key, value);
        }
    }
}