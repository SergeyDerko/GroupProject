using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_Num{
    class MainClass{
        public static void Main(string[] args){
            int num, num_1;

            Console.WriteLine("Enter first num: ");
            num = Convert.ToInt32(Console.ReadLine());
            //приведення введених  строкових даних з клавіатури користувачем до типу int
            Console.WriteLine("\nEnter second num: ");
            //розділення виведених данних через строку пропуску 
            num_1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result is: " + (num+num_1).ToString());
            //приєднання до строкових даних через оператор "+", оператор ToString приводить всі данні до строкових елементів
            Console.ReadKey();

        }
    }
} 