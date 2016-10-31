using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using _09_Serialization.modal;


namespace _09_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"output/";
            var arr = new List<User>();
            var random = new Random();
            for (var i = 1; i < 10; i++)
            {
                arr.Add(new User {Name = $"Bill{i}", SName = $"Gates{i}", Age = 25 + random.Next(1, 30)});
            }
            var outputObject = JsonConvert.SerializeObject(arr);
            File.WriteAllText(path + "out.json", outputObject);
            
            var inputObject = JsonConvert.DeserializeObject(File.ReadAllText(path + "out.json"));
            Console.WriteLine($"Результат в файле {path}out.json");
            Console.WriteLine(inputObject);


            Console.ReadKey();
        }
    }
}
