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
        private readonly OperDelegate _operDelegate;

        private delegate int OperDelegate(int a, int b);
        public Calc(Operation operation)
        {
            switch (operation)
            {
                case Operation.Sum:
                case Operation.Min:
                case Operation.Prz:
                case Operation.Del:
                    _operDelegate = (x, y) => { return Sum(x, y); };
                    _operDelegate += Min;
                    _operDelegate += Prz;
                    _operDelegate += Del;
                    _operDelegate -= (x, y) => { return Sum(x, y); };
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