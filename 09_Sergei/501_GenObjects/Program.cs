using Newtonsoft.Json;
using System;
using System.IO;

namespace _501_GenObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User { Name = "Jonh", SName = "Smith", DateBirth = DateTime.FromOADate(12) };
            var obj = JsonConvert.SerializeObject(user);
            Directory.CreateDirectory(@"../../Dir");
            var pathDir = @"../../Dir/";
            var pathFile = @"D:/Gitprojects/GroupProject/09_Sergei/501_GenObjects/Dir/File.txt";
            File.Create(pathFile);
            File.AppendAllText(pathFile,obj);
            var input = JsonConvert.DeserializeObject(File.ReadAllText(pathFile));
            Console.WriteLine(input);
            Console.ReadKey();
        }
    }
    
}
