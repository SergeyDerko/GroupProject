using System.Collections.Generic;
using System.Text;

namespace TestWcfSite.Models.PikhotaSerhiiModels
{
    public class TablesOfMathActions
    {
        public List<string> MultyTable()
        {
            var list = new List<string>();
            var str = new StringBuilder();
            for (var i = 2; i < 10; i++)
            {
                for (var j = 2; j < 10; j++)
                {
                    str.Append($"{i}x{j}={i * j}");
                    list.Add(str.ToString());
                    str.Clear();
                }
            }
            return list;
        }

        public List<string> DivTable()
        {
            var list = new List<string>();
            var str = new StringBuilder();
            for (var i = 2; i < 10; i++)
            {
                for (var j = 2; j < 10; j++)
                {

                    var result = i % j == 0
                        ? str.Append($"{i}/{j}={i / j}")
                        : str.Append($"{i}/{j}={((double)i / (double)j):N2}");
                    list.Add(result.ToString());
                    str.Clear();
                }

            }
            return list;
        }

        public List<string> SumTable()
        {
            var list = new List<string>();
            var str = new StringBuilder();
            for (var i = 2; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {

                    str.Append($"{i}+{j}={i + j}");
                    list.Add(str.ToString());
                    str.Clear();
                }

            }
            return list;
        }

        public List<string> SubTable()
        {
            var list = new List<string>();
            var str = new StringBuilder();
            for (var i = 2; i < 10; i++)
            {
                for (int j = 2; j < 10; j++)
                {

                    str.Append($"{i}-{j}={i - j}");
                    list.Add(str.ToString());
                    str.Clear();
                }

            }
            return list;
        }
    }
}