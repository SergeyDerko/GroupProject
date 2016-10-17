using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Common.modal;
using Newtonsoft.Json;


namespace _Zoo_vo
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<IAnimal>
            {
                new Mammals(),
                new Birds()

            };
        
            var json = JsonConvert.SerializeObject(animals);
            var path = "out.json";
            File.WriteAllText(path, json);
            var text = File.ReadAllText(path);
            Console.WriteLine(text);
            var finish = JsonConvert.DeserializeObject<IAnimal>(text);
      
        }

        public class Woodpecker : Birds
        {
            public int Hardbeak { get; set; }
        }

        
        
        

    }

}
