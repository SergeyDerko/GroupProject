using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.modal;

namespace _10_Zoo_
{
    class Program
    {
        static void Main(string[] args)
        {

            var animals = new List<IAnimal>
            {
               new Birds() {Id = 1, BirdsRace = BirdsRace.Dove,Birthday = DateTime.Today,Nickname = "First", Sex = Sex.Male}


            };

           


            Console.ReadKey();
        }
    }
}
