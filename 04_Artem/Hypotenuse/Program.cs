using System;

namespace Hypotenuse
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the first cathetus length:");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second cathetus length:");
            var y = Convert.ToInt32(Console.ReadLine());

            var z = Math.Sqrt(x*x +y*y);
      
            Console.Write("The hypothenuse of the triangle with cathetuses " + x);
            Console.Write(" and " + y);
            Console.Write(" equals " + z);
        
            Console.ReadKey();
        }
    }
}
