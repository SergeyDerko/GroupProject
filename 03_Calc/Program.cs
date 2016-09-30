using System;

namespace _03_Calc
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter your first number");
            var a = Convert.ToInt32(Console.ReadLine());

           Console.WriteLine("enter your action (+, -, * or / )");
            var z = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("enter your second number");
            var b = Convert.ToInt32(Console.ReadLine());

            var c = 0;

            switch (z)
            {
               case '+':
                {
                    c = a + b;
                    break;
                }
                case '-':
                {
                    c = a - b;
                    break;
                }
                case '*':
                {
                    c = a * b;
                        break;
                }
                 case '/':
                {
                    if (b == 0)
                            Console.WriteLine("You can not divide by zero");
                        else c = a / b;
                        break;
                }
                default:
                {
                    Console.WriteLine("Wrong expression!");
                        break;
                }
            }

                var res = $"{a} {z} {b} = {c}";
                Console.WriteLine(res);
                
          }
    }
}