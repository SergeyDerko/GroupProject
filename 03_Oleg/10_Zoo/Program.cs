using Common.modal;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using _10_Zoo.Modya;


namespace _10_Zoo
{
    class Program: ZombyLand
    {
        static void Main(string[] args)
        {
            var animals = new List<IAnimal>
                /*{
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
                Console.WriteLine(text);*/
                {
                    new Birds() {Id = 1, BirdsRace = BirdsRace.Dove,Birthday = DateTime.Today,Nickname = "First", Sex = Sex.Male, Eatbrain = brain.want}
                };

            Console.ReadLine();
        }
    }
}
