using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Model;

namespace Zoo
{
    class Program
    {
        static void PrintUpperSedcr (IMeth obj)
        {
            Console.WriteLine(obj.GetDescription().ToUpper());
        }
        static void Main(string[] args)
        {
            Bird br = new Bird()
            {
                Subclass = "Paleognathae",
                Name = "PopugaGalya",
                Population = 23524365,
                Size = 21
            };

            Fish fr = new Fish()
            {
                Classer = "Acanthodii",
                Name = "Piranyy",
                Population = 347239854,
                Size = 12
            };

            Console.WriteLine("Info:");
            Console.WriteLine(br.GetDescription());
            Console.WriteLine(fr.GetDescription());

            Console.WriteLine("General information:");
            Console.WriteLine(br.ItemProperty);
            Console.WriteLine(fr.ItemProperty);
            Console.WriteLine();
            Console.WriteLine("All description (Upper):");
            PrintUpperSedcr(br);
            PrintUpperSedcr(fr);

            Console.ReadLine();
        }
    }
}
