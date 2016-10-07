using System;

namespace _07_home
{
    class Program
    {
        static void Main()
        {
            var gamer = new IGamer(){ Name = "Rex"};
            var school = new ISchool() { Name = "John" };
            var student = new IStudent() { Name = "Den" };
            var worker = new IWorker() { Name = "Nik" };

            Console.WriteLine($"I am {gamer.Name}. {gamer.WhatIdo()}");
            Console.WriteLine($"I am {school.Name}. {school.WhatIdo()}");
            Console.WriteLine($"I am {student.Name}. {student.WhatIdo()}");
            Console.WriteLine($"I am {worker.Name}. {worker.WhatIdo()}");

            
            Console.ReadLine();
        }
    }
}
