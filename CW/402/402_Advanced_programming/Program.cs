// материал взят с ресурса http://professorweb.ru
using System;
using _402_Advanced_programming.Model;

namespace _402_Advanced_programming
{
    public class Program
    {
        static void Main()
        {
            var str = "22222+ 22222 *222212";
            var s = str.Replace(" ", "");
            var index = s.IndexOf("*");
            var exp = SearchExp(index, s);
            //s.Replace(exp, Calc(exp).ToString());

            Employee();
            Additions();
            Points();
        }

        private static string SearchExp(int index, string s)
        {
            var indexEnd = index;
            var indexStart = index;
            //var substring = s.Substring(i, s.Length - i);
            for (int i = index + 1; i < s.Length; i++)
            {
                if (!char.IsDigit(s[i]))
                {
                    break;
                }
                indexEnd = i;
            }
            for (int i = index - 1; i > 0; i--)
            {
                if (!char.IsDigit(s[i]))
                {
                    break;
                }
                indexStart = i;
            }
            return s.Substring(indexStart, indexEnd - indexStart + 1);
        }

        private static void Employee()
        {
            var employee = new Employee {
                Birthday = DateTime.Now,
                Name = "Name",
                SName = "Sname",
                EmployeeId = Guid.NewGuid().ToString("N").ToUpper(),
                Login = "Login",
                Password = "Password"
            };
            Person person = null;
            if (employee is Person)
            {
                person = (Person) employee;
            }

            var @equals = employee.Equals(person);

            var person1 = new Person
            {
                Birthday = DateTime.Now,
                Name = "Name",
                SName = "Sname",
            };
            var employee1 = new Employee();
            if (person1 is Employee)
            {
                employee1 = (Employee) person1;
            }
            Employee person2 = person1 as Employee;
            if (person2 == null)
            {
                
            }
            var e = person as Employee;
            var b = e.Equals(employee);
            b.ToString();
        }

        private static void Points()
        {
            Point point = new Point();
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
