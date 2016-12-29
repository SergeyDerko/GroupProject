using System.Collections.Generic;

namespace TestWcfSite.Models.Yuriymodels
{
    public class Expression
    {
        public int A { get; set; }
        public int B { get; set; }
        public int Result()
        {
            return A*B;
        }
        public Expression()
        {
         
        }
        public List<Expression> TableExpressions(int a)
        {
            var table = new List<Expression>();
            for (var i = 1; i <= 10; i++)
            {
                table.Add(new Expression { A = a, B = i });
            }
            return table;
        }
        //public List<Expression> AllTableExpressions()
        //{
        //    var table = new List<Expression>();
        //    for (int i = 2; i < 10; i++)
        //    {
        //        for (int j = 1 ; j <= 10; j++)
        //        {
        //            table.Add(new Expression { A = i, B = j });
                   
        //        }
        //    }
            
        //    return table;
        //}

    }

}