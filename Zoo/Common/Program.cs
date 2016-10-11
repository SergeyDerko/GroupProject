using System;
using Common.modal;

namespace Common
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n" + new string('*', 20) + "Our zoo" + new string('*', 20) + "\n\n Определены классами виды животных:");
            var output = new[]
            {
                typeof(TypeAnimal),
                typeof(MammalsRace),
                typeof(Birds.BirdsRace),
                typeof(FishRace),
                typeof(ReptilesRace),
                typeof(AmphibianRace)
            };
            NewMethod(output[0]);
            Console.WriteLine(" В классе Mammals определены животные: ");
            NewMethod(output[1]);
            Console.WriteLine(" В классе Birds определены животные: ");
            NewMethod(output[2]);
            Console.WriteLine(" В классе Fish определены животные: ");
            NewMethod(output[3]);
            Console.WriteLine(" В классе Reptiles определены животные: ");
            NewMethod(output[4]);
            Console.WriteLine(" В классе Amphibian определены животные: ");
            NewMethod(output[5]);


            Console.WriteLine("\n Дальше заполняем зоопарк животными :)");
            Console.ReadKey();
        }

        private static void NewMethod(Type x)
        { 
            foreach (var i in Enum.GetValues(x))
            {
                Console.Write($"  {i}");
             }
            Console.WriteLine("\n" + new string('-', 47));
        }


    }
}
