using System;

namespace _04_GeneretionOfExamples
{
    public class Example
    {
        //public Random Ran1 { get; } = new Random();
        //public Random Ran2 { get; } = new Random();
        public int Number1 { get; }
        public int Number2 { get; }

        internal Example(int range1, int range2)
        {
           // Ran1.Next(range1);
           // Ran2.Next(range2);
            Number1 = range1;
            Number2 = range2;
        }

        /*internal Example(int rangeMin1, int rangeMax1, int rangeMin2, int rangeMax2 )
        {
           Number1 = Ran1.Next(rangeMin1,rangeMax1);
           Number2 = Ran2.Next(rangeMin2, rangeMax2);
        }*/

        public void Next()
        {
            var rand = new Random();
            var action = rand.Next(1,4);
            var result = 0;
            switch (action)
            {
                case 1:
                    result = Number1 + Number2;
                    Console.WriteLine("Action plus: " + result);
                    break;
                case 2:
                    result = Number1 - Number2;
                    Console.WriteLine("Action minus: " + result);
                    break;
                case 3:
                    result = Number1 * Number2;
                    Console.WriteLine("Action multiplication: " + result);
                    break;
                case 4:
                    result = Number1/Number2;
                    Console.WriteLine("Action division: " + result);
                    break;
                default:
                    
                    break;
            }
        }
    }
}