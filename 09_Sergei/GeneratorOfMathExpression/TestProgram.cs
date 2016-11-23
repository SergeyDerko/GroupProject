using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace GeneratorOfMathExpression
{
    internal class TestProgram
    {
        private static void Main()
        {
            /*var r = new Random();
            for (var i = 0; i < 10; i++)
            {
                var s = Generator.TextGerenator();
                Console.WriteLine(s);
                Thread.Sleep(r.Next(500,1500));
            }*/
            
            /*var str = Generator.TextGerenator();
            Console.WriteLine(str);*/
            //var t1 = new Thread(x =>
            //{
            //    var str = Generator.ExpressionGenerator();
            //    Console.WriteLine(str);
            //});
            

            //var t2 = new Thread(x =>
            //{
            //    Generator.FileGenerator($@"D:\Gitprojects\GroupProject\09_Sergei\GeneratorOfMathExpression\test\", null);
            //});
            //t1.Start();
            //t2.Start();
        }
    }
}
