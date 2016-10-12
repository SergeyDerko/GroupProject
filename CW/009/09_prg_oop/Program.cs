using System.IO;
using Newtonsoft.Json;
using _09_prg_oop.Model;

namespace _09_prg_oop
{
    class Program
    {
        static void Main()
        {
            var json = JsonConvert.SerializeObject(new User());
            /*var json2 = JsonConvert.SerializeObject(new User());*/
            File.WriteAllText("out.json", json); 
        }
    }
}
