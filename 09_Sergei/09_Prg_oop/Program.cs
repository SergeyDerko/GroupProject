using System;
using System.IO;
using Newtonsoft.Json;

namespace _09_Prg_oop
{
    internal class Program
    {
        private static void Main()
        {
            var json = JsonConvert.SerializeObject(new User("Jonh","Smith",30));
            File.WriteAllText("out.json",json);

            Console.WriteLine(File.ReadAllText("out.json"));
            ;
        }
    }
}