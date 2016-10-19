namespace _012_try
{
    enum Operation
    {
        Sum,
        Min,
        Prz,
        Del
    }

    internal class Calc
    {
        private OperDelegate _operDelegate;

        private delegate int OperDelegate(int a, int b);
        public Calc(Operation operation)
        {
            switch (operation)
            {
                case Operation.Sum:
                    _operDelegate = Sum;
                    break;
                case Operation.Min:
                    _operDelegate = Min;
                    break;
                case Operation.Prz:
                    _operDelegate = Prz;
                    break;
                case Operation.Del:
                    _operDelegate = Del;
                    break;
            }
        }
        public int Calculation(int a, int b)
        {
            return _operDelegate(a, b);
        }

        // Организуем ряд методов
        static int Sum(int x, int y)
        {
            return x + y;
        }

        static int Min(int x, int y)
        {
            return x - y;
        }

        static int Prz(int x, int y)
        {
            return x * y;
        }

        static int Del(int x, int y)
        {
            return x / y;
        }

    }
}