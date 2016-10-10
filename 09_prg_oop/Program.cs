using System;
using System.IO;
using Newtonsoft.Json;

namespace _09_prg_oop
{
    internal class Program
    {
        private static void Main()
        {


            var json = JsonConvert.SerializeObject(new User());
            File.WriteAllText("out.json", json);

            
            Console.ReadKey();
        }
    }

    internal class User : IUser

    {
        public string Name { get; set; }
        public string Sname { get; set; }
        public int Age { get; set; }
    }
}