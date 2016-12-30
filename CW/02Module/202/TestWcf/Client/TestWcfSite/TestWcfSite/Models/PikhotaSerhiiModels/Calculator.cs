using System.Collections.Generic;
using System.Text;

namespace TestWcfSite.Models.PikhotaSerhiiModels
{
    public class Calculator
    {
        public int Value { get; set; }
        public int Count { get; set; }
        public int StartIndex { get; set; }

        public Calculator()
        {
        }

        public Calculator(int value, int count, int startIndex)
        {
            Value = value;
            Count = count;
            StartIndex = startIndex;
        }



        public List<string> Mult()
        {
            var list = new List<string>();
            var str = new StringBuilder();
            for (var i = StartIndex; i < Count+StartIndex; i++)
            {
                str.Append($"{Value}x{i}={Value * i}");
                list.Add(str.ToString());
                str.Clear();
            } 
            return list;
        }

        public List<string> Sum()
        {
            var list = new List<string>();
            var str = new StringBuilder();
            for (var i = StartIndex; i < Count + StartIndex; i++)
            {
                str.Append($"{Value}+{i}={Value + i}");
                list.Add(str.ToString());
                str.Clear();
            }
            return list;
        }

        public List<string> Div()
        {
            var list = new List<string>();
            var str = new StringBuilder();
            for (var i = StartIndex; i < Count + StartIndex; i++)
            {
                if (i == 0 )
                {
                    str.Append("Деление на ноль!");
                    list.Add(str.ToString());
                    str.Clear();
                    continue;
                }
                var result = Value %  i == 0 ? 
                str.Append($"{Value}/{i}={(Value / i)}")
                : str.Append($"{(double)Value}/{(double)i}={((double)Value / (double)i):N2}");
                list.Add(result.ToString());
                str.Clear();
            }
            return list;
        }
        public List<string> Sub()
        {
            var list = new List<string>();
            var str = new StringBuilder();
            for (var i = StartIndex; i < Count + StartIndex; i++)
            {
                str.Append($"{Value}-{i}={Value - i}");
                list.Add(str.ToString());
                str.Clear();
            }
            return list;
        }

    }
}