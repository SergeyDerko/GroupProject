
using System.IO;
using System.Net;

namespace WebLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines(args[0]);
            foreach (var item in lines)
            {
                using (var client = new WebClient())
                {
                    string fileName = item.Substring(item.LastIndexOf("/") + 1);
                    client.DownloadFile(item, fileName);
                }
            }
        }
    }
}
