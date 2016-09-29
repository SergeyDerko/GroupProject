using System;
using System.Collections.Generic;

namespace _04_AutoShop
{
	class Program
	{
		static void Main()
		{
			// Создадим множество автомобилей
			List<AutoShop> dic = new List<AutoShop>
			{
				new AutoShop("Toyota Corolla", 180, 300000, 5, 1),
				new AutoShop("VAZ 2114i", 160, 220000, 0, 2),
				new AutoShop("Daewoo Nexia", 140, 260000, 5, 3),
				new AutoShop("Honda Torneo", 220, 400000, 7, 4),
				new AutoShop("Audi R8 Best", 360, 4200000, 3, 5)
			};


			Console.WriteLine("Исходный каталог автомобилей: \n");
			foreach (AutoShop a in dic)
				Console.WriteLine(a);

			Console.WriteLine("\nТеперь автомобили отсортированны по стоимости: \n");
			dic.Sort();
			foreach (AutoShop a in dic)
				Console.WriteLine(a);

			Console.ReadLine();
		}
	}
}
