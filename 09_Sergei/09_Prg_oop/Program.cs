using System.IO;
using Newtonsoft.Json;

namespace _09_Prg_oop
{
    internal class Program
    {
        private static void Main()
        {
            var json = JsonConvert.SerializeObject(new User());
            File.WriteAllText("out.json",json);
        }

    }
}