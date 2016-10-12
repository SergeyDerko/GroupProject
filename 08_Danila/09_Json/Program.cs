using System;
using System.IO;
using Newtonsoft.Json;
using _09_Json.Model ;

namespace _09_Json
{
    class Program
    {
        public static Guid NewGuid()
        {
            return Guid.NewGuid();
            
        }
        static void Main()
        {
            usr anim = new usr();
            anim.Name = "Волк";
            anim.Color = "Белый";
            anim.Age = "5" ;
            anim.Id = NewGuid(); 
            var json1 = JsonConvert.SerializeObject(anim);
            File.WriteAllText("out.json1", json1);
            usr bird = new usr();
            bird.Name = "Дятел";
            bird.Color = "Цветной";
            bird.Age = "2";
            bird.Id = NewGuid() ;
            var json = JsonConvert.SerializeObject(bird );
            File.WriteAllText("out.json", json);
            var parth = "out.json";
            var parth1 = "out.json1";
            Console.WriteLine(File.ReadAllText(parth));
            Console.WriteLine(File.ReadAllText(parth1));
           
            Console.ReadLine();
        }
    }
}
