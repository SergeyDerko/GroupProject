using System;
using System.Collections.Generic;
using System.IO;
using Common.modal;
using Newtonsoft.Json;

namespace _10_zoo
{
    class Program
    {
        static void Main()
        {
            var animals = new List<IAnimal>
            {
                new Mammals(),
                new Birds(),
                new Reptiles(),
                new Fish(),
                new Amphibian()
            };

            var jsonE = JsonConvert.SerializeObject(animals);
            var path = "out.json";
            File.WriteAllText(path, null);
            File.AppendAllText(path, jsonE);

            var text = File.ReadAllText(path);
            Console.WriteLine(text);

            Console.ReadLine();
        }
    }
}
