using System;
using System.IO;
using System.Security.Policy;
using Jaysone.Model;
using Newtonsoft.Json;


namespace Jaysone
{
    class Program
    {
        public static Guid NewGuid()//метод GUID для Id животных 
        {
            return Guid.NewGuid();
        }

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
