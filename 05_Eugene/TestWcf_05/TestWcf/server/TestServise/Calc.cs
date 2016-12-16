using TestWcfCommon;

namespace TestServise
{
    public class Calc: ICalc
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}