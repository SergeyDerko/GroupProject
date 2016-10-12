using System;
using System.IO;
using Newtonsoft.Json;
using _09_Serialization.modal;


namespace _09_Serialization
{
    class Program
    {
        static void Main(string[] args)
        {

            var user = new User {Name = "Bill", SName = "First", Age = 25};
            var output = JsonConvert.SerializeObject(user);
            //var path = "out.json";
            var path = args[0];
            File.WriteAllText(path, output);
            var input = JsonConvert.DeserializeObject(File.ReadAllText(path));

            Console.WriteLine(input);
            
            Console.ReadKey();
        }
    }
}
