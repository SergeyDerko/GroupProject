using System;
using System.Collections.Generic;
using System.IO;
using Common.modal;
using Newtonsoft.Json;

namespace _10_Zoo_
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<IAnimal>
            {
                new Mammals(),
                new Birds(),
                new Amphibian(),
                new Fish(),
                new Reptiles(),
            };
            var output = JsonConvert.SerializeObject(animals);
            var path = "out.json";
            File.WriteAllText(path, output);
            var input = JsonConvert.DeserializeObject(File.ReadAllText(path));

            Console.WriteLine(input);

            Console.ReadKey();
        }
    }
}
