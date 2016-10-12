using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.modal;


namespace _Zoo_vo
{
    class Program
    {
        static void Main(string[] args)
        {
            var animals = new List<IAnimal>
            {
                new Mammals(),
                new Birds()

            };
        }
    }
}
