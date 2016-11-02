using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var enym = new User();
            enym.Name = "Kit ";
            enym.SName = "Fish ";
            enym.Age = 22;
            enym.Id = NewGuid();

            User bird = new User();
            bird.Name = "Kolybri ";
            bird.SName = "Kakadu ";
            bird.Age = 5;
            bird.Id = NewGuid();

            var jsonE = JsonConvert.SerializeObject(enym);
            var jsonB = JsonConvert.SerializeObject(bird);
            var path = "out.json";
            File.WriteAllText(path, null);
            File.AppendAllText(path, jsonE);
            File.AppendAllText(path, jsonB);

            var text = File.ReadAllText(path);
            Console.WriteLine(text);

            Console.ReadLine();
        }
    }
}
