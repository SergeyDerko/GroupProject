using System.Collections.Generic;
using System.Text;

namespace TestWcfSite.Models
{
    public class Multiply
    {
        public int Value { get; set; }
        public int Count { get; set; }
        public int StartIndex { get; set; }

        public Multiply()
        {
        }

        public Multiply(int value, int count, int startIndex)
        {
            Value = value;
            Count = count;
            StartIndex = startIndex;
        }


        public List<string> Multy()
        {

            var list = new List<string>();
            StartIndex = 2;
            var str = new StringBuilder();
            for (var i = StartIndex; i < Count+StartIndex; i++)
            {
                str.Append($"{Value}x{i}={Value * i}");
                list.Add(str.ToString());
                str.Clear();
            } 
            return list;
        }
    }
}