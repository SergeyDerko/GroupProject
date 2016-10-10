using System;
using System.IO;
using Newtonsoft.Json;
using _09_Prg_oop.Model;

namespace _09_Prg_oop
{
    internal class Program
    {
        private static void Main()
        {
            var persone = new User("Jonh", "Smith", 30);
            var persone2 = new User("Vasya", "Pupkin", 27);
            var persone3 = new User("Vadym", "Klym", 26);
            var arrObjs = new[] {persone, persone2 , persone3};

            
            var json = JsonConvert.SerializeObject(arrObjs);
            
            var path = "out.json";
           // var conf = "out.config";
            File.WriteAllText(path, json);
            Console.WriteLine(File.ReadAllText(path));
        }
    }
}