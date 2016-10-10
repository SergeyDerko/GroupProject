using System;
using System.IO;
using Newtonsoft.Json;

namespace _08_zoo
{
    class Program
    {
        static void Main()
        {
            Animal a = new Animal();
            a.Mammal = "bear";
            a.Mammal = "wolf";
            a.Bird = "eagle";
            a.Bird = "hawk";

var json = JsonConvert.SerializeObject(new Animal());
            var path = "out.json";
            File.WriteAllText(path, json);
            var text = File.ReadAllText(path);
            var c = JsonConvert.DeserializeObject(text);

            Console.WriteLine(c);
        }
    }

    internal class Animal : IAnimal
    {
            public string Mammal { get; set; }
            public string Bird { get; set; }
    }
}
