using System;
using TestWcfTypes.Expressions;

namespace TestWcfDB
{
    public class Program
    {
        public static void Main()
        {
            //using (var db = new StudentsContext())
            //{
            //    var student1 = new Student{Name = "Олег", Surname = "Хлопов", Age = 21,  Programlanguage = "С#"};
            //    var student2 = new Student{Name = "Артем", Surname = "Аникеев", Age = 22,  Programlanguage = "С#"};
            //    var student3 = new Student{Name = "Юрий", Surname = "Матвийчук", Age = 23,  Programlanguage = "С#"};
            //    var student4 = new Student{Name = "Даниил", Surname = "Акольцев", Age = 24,  Programlanguage = "С#"};
            //    var student5 = new Student{Name = "Сергей", Surname = "Пехота", Age = 25,  Programlanguage = "С#"};
            //    var student6 = new Student{Name = "Анастасия", Surname = "Непомилуєва", Age = 26,  Programlanguage = "С#"};
            //    var student7 = new Student{Name = "Сергей", Surname = "Дерко", Age = 27,  Programlanguage = "С#"};
            //    var student8 = new Student{Name = "Алексей", Surname = "Антонов", Age = 28,  Programlanguage = "С#"};
                
            //    db.Students.Add(student1);
            //    db.Students.Add(student2);
            //    db.Students.Add(student3);
            //    db.Students.Add(student4);
            //    db.Students.Add(student5);
            //    db.Students.Add(student6);
            //    db.Students.Add(student7);
            //    db.Students.Add(student8);
            //    db.SaveChanges();
            
            //}
            using (var ctx = new CalcContext())
            {
                ctx.Expressions.Add(new Expression());
                ctx.SaveChanges();
            }
            Console.WriteLine("Completed");
            Console.ReadKey();
        }
    }
}
