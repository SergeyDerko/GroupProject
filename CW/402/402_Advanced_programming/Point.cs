namespace _402_Advanced_programming
{
    public class Point
    {
        protected bool Equals(Point other)
        {
            return x == other.x && y == other.y && z == other.z;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Point) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = x;
                hashCode = (hashCode*397) ^ y;
                hashCode = (hashCode*397) ^ z;
                return hashCode;
            }
        }

        // Координаты точки в трехмерном пространстве
        internal int x, y, z;

        public Point(int x = 0, int y = 0, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Перегружаем бинарный оператор +
        public static Point operator +(Point obj1, Point obj2)
        {
            Point arr = new Point
            {
                x = obj1.x + obj2.x,
                y = obj1.y + obj2.y,
                z = obj1.z + obj2.z
            };
            return arr;
        }

        // Перегружаем бинарный оператор - 
        public static Point operator -(Point obj1, Point obj2)
        {
            Point arr = new Point
            {
                x = obj1.x - obj2.x,
                y = obj1.y - obj2.y,
                z = obj1.z - obj2.z
            };
            return arr;
        }

        // Перегружаем унарный оператор -
        public static Point operator -(Point obj1)
        {
            Point arr = new Point
            {
                x = -obj1.x,
                y = -obj1.y,
                z = -obj1.z
            };
            return arr;
        }

        // Перегружаем унарный оператор ++
        public static Point operator ++(Point obj1)
        {
            obj1.x += 1;
            obj1.y += 1;
            obj1.z += 1;
            return obj1;
        }

        // Перегружаем унарный оператор --
        public static Point operator --(Point obj1)
        {
            obj1.x -= 1;
            obj1.y -= 1;
            obj1.z -= 1;
            return obj1;
        }

        // Перегружаем логический оператор ==
        public static bool operator ==(Point obj1, Point obj2)
        {
            if ((obj1.x == obj2.x) && (obj1.y == obj2.y) && (obj1.z == obj2.z))
                return true;
            return false;
        }

        // Теперь обязательно нужно перегрузить логический оператор !=
        public static bool operator !=(Point obj1, Point obj2)
        {
            if ((obj1.x != obj2.x) || (obj1.y != obj2.y) || (obj1.z != obj2.z))
                return true;
            return false;
        }

        // Перегружаем оператор false
        public static bool operator false(Point obj)
        {
            if ((obj.x <= 0) || (obj.y <= 0) || (obj.z <= 0))
                return true;
            return false;
        }

        // Обязательно перегружаем оператор true
        public static bool operator true(Point obj)
        {
            if ((obj.x > 0) && (obj.y > 0) && (obj.z > 0))
                return true;
            return false;
        }

        // Перегружаем логический оператор &
        public static bool operator &(Point obj1, Point obj2)
        {
            if (((obj1.x > 0) && (obj1.y > 0) && (obj1.z > 0))
                & ((obj2.x > 0) && (obj2.y > 0) && (obj2.z > 0)))
                return true;
            return false;
        }

        // Перегружаем логический оператор !
        public static bool operator !(Point obj1)
        {
            if ((obj1.x > 0) && (obj1.y > 0) && (obj1.z > 0))
                return false;
            return true;
        }

        // Явное преобразование типа к string
        public static explicit operator string(Point point)
        {
            return $@"x = {point.x}, y = {point.y}, z = {point.z}";
        }
    }
}