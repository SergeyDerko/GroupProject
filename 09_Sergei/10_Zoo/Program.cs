using System;
using System.Collections.Generic;
using System.IO;
using Common.modal;
using Newtonsoft.Json;

namespace _10_Zoo
{
    class Program
    {
        private static void Main()
        {

            /*var animals = new List<IAnimal>
            {
                new Reptiles(),
                new Amphibian(),
                new Birds(),
                new Fish(),
                new Mammals()
            };*/



          //  var json = JsonConvert.SerializeObject(animals);
            /*var path = "animals.json";
            File.WriteAllText(path, json);
            Console.WriteLine(File.ReadAllText(path));*/
            AncientBirds r = new AncientBirds();
        }

    }
}
