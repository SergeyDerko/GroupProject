namespace TestWcfSite.Models.Yuriymodels
{
    public class Expression
    {
        public int A { get; set; }
        public int B { get; set; }
        public Operation Operation { get; set; }

        public int Result()
        {
            return A*B;
        }
    }
    

    public enum Operation
    {
        Mult = 3
    }
}