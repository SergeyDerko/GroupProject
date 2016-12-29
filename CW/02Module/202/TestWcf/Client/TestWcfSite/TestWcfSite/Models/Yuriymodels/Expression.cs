namespace TestWcfSite.Models.Yuriymodels
{
    public class Expression
    {
        public int A { get; set; }
        public int B { get; set; } = 1;

        public int Result()
        {
            return A*B;
        }

        public Expression()
        {
            
        }
        public Expression(int a)
        {
            A = a;
        }
    }
}