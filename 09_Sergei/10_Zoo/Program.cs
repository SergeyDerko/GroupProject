using System;
using System.Collections.Generic;
using System.IO;
using Common.modal;
using Newtonsoft.Json;

namespace _10_Zoo
{
    class Program
    {
        static void Main(string[] args)
        {

            var animals = new List<IAnimal>
            {
                new Reptiles(),
                new Amphibian(),
                new Birds(),
                new Fish(),
                new Mammals()
            };
            var json = JsonConvert.SerializeObject(animals);
            var path = "out.json";
            File.WriteAllText(path, json);
            Console.WriteLine(File.ReadAllText(path));
        }
    }
}
