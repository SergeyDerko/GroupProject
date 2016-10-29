using System;
using System.IO;
using System.Security.Policy;
using Jaysone.Model;
using Newtonsoft.Json;


namespace Jaysone
{
    class Program
    {
        public static Guid NewGuid()//метод GUID для Id
        {
            return Guid.NewGuid();
        }

    static void Main(string[] args)
    {
            var enym = new User();
            var path = string.Empty;
            path = @"D:\new\new.json";
            string pathFin = @"D:\new\fin.json";
            string direct = @"D:\new";
            var jsonE = JsonConvert.SerializeObject(enym);
            /*
            for (int n = 0; n < 10000; n++)
            {    
                enym.Name = "Kitee " + n;
                enym.SName = "Prety " + n;
                enym.Age = 22 + n;
                enym.Id = NewGuid();
                File.WriteAllText(path, jsonE);
            }*/

            /*
            User bird = new User();
            bird.Name = "Vasya ";
            bird.SName = "Pupkin ";
            bird.Age = 5;
            bird.Id = NewGuid();
            */         
            //var jsonB = JsonConvert.SerializeObject(bird);    

            for (int i = 1; i < 10000; i++)
            {
                path = @"D:\new\new"+ i +".json";
                File.WriteAllText(path, jsonE);
            }
            //File.AppendAllText(path, jsonE);
            //File.AppendAllText(path, jsonB);

            //var text = File.ReadAllText(path);
            //Console.WriteLine(text);

            var txt = Directory.EnumerateFiles(direct, "*.json");
            var Final = JsonConvert.SerializeObject(txt);
            File.WriteAllText(pathFin, Final);
            var finnal = File.ReadAllText(pathFin);
            Console.WriteLine("\n " + finnal);
            Console.ReadLine();
        }
    }
}
