// материал взят с ресурса http://professorweb.ru
using System;
using _402_Advanced_programming.Model;

namespace _402_Advanced_programming
{
    public class Program
    {
        static void Main()
        {
            Employee();
            Additions();
            Points();
        }

        private static void Employee()
        {
            var employee = new Employee();
            Person person = null;
            if (employee is Person)
            {
                person = (Person) employee;
            }

            var e = person as Employee;
            var b = e.Equals(employee);
            b.ToString();
        }

        private static void Points()
        {
            Point point1 = new Point(1, 12, -4);
            Point point2 = new Point(0, -3, 18);
            Console.WriteLine("Координаты первой точки: " +
                 point1.x + " " + point1.y + " " + point1.z);
            Console.WriteLine("Координаты второй точки: " +
                point2.x + " " + point2.y + " " + point2.z + "\n");

            Point point3 = point1 + point2;
            Console.WriteLine("\nPoint1 + Point2 = "
                + point3.x + " " + point3.y + " " + point3.z);
            point3 = point1 - point2;
            Console.WriteLine("Point1 - Point2 = "
                + point3.x + " " + point3.y + " " + point3.z);
            point3 = -point1;
            Console.WriteLine("-Point1 = "
                + point3.x + " " + point3.y + " " + point3.z);
            point2++;
            Console.WriteLine("Point2++ = " + point2.x + " " + point2.y + " " + point2.z);
            point2--;
            Console.WriteLine("Point2-- = " + point2.x + " " + point2.y + " " + point2.z);

            if (point1 == point2)
                Console.WriteLine("Объекты равны");

            if (point1)
                Console.WriteLine("Все координаты объекта myObject1 положительны");

            if (point1 & point2)
                Console.WriteLine("У объектов все координаты положительные");
            else
                Console.WriteLine("Есть отрицательные или равные нулю координаты");

            if (!point2)
                Console.WriteLine("Во втором объекте есть отрицательные координаты");

            Console.ReadLine();
        }

        private static void Additions()
        {
            MyArray arr = new MyArray(5)
            {
                [0] = 5,
                [1.235] = 12,
                [2] = 3,
                [3.045] = 18,
                [3.9] = 1
            };

            Console.WriteLine("Получившийся массив: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write("{0}\t", arr[i]);

            Console.ReadLine();
        }
    }
}
