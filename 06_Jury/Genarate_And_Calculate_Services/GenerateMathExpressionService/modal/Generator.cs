using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateMathExpressionService.modal
{
    internal class Generator
    {
        private static readonly string FolderForFiles =
            Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"..\..\..\files\";

        private static readonly Random Random = new Random();

        public  Generator()
        {
           var example = new StringBuilder();
           for (var j = 0; j <= Random.Next(10); j++) // рандомное количество примеров в файле
            {
                for (var i = 0; i <= Random.Next(3, 20); i++) // рандомное количество елементов выражения
                {
                    if (i == 0)
                        example.Append(Random.Next(1, 1000));
                    example.Append(Operation());
                    example.Append(Random.Next(1, 1000));
                }
                example.AppendLine();
            }

            
            File.WriteAllText(FolderForFiles + GetRandomFileName(), example.ToString());
            Console.ReadKey();
        }
        private static string GetRandomFileName()
        {
            var path = Path.GetRandomFileName();
            path = path.Replace(".", "");
            return $"file_{path}.txt";
        }
        private static string Operation()
        {
            var operations = new[] {"*", "/", "+", "-"};
            return operations[Random.Next(4)];
        }
    }
}
